---
title: Keep intended-red practice outside the root green solution
date: 2026-07-27
category: conventions
module: chapters/01-getting-started
problem_type: convention
component: testing_framework
severity: medium
applies_when:
  - "A beginner exercise deliberately starts with a failing test"
  - "The repository root must remain an always-green validation surface"
  - "Maintainers need to prove the learner's completed state without changing the committed exercise"
tags:
  - red-green
  - xunit
  - practice-tests
  - solution-isolation
  - beginner-exercises
---

# Keep intended-red practice outside the root green solution

## Context

A red-green exercise has two valid states that cannot both be committed in the same file: the learner needs an initial failure, while maintainers need a trustworthy green repository baseline.

Chapter 1 keeps the initial failure real. The practice greeting returns an empty string (`chapters/01-getting-started/practice/HelloWorld/Greeting.cs:5`), while its xUnit test expects `Hello, World!` (`chapters/01-getting-started/tests/HelloWorld.Practice.Tests/GreetingTests.cs:6`). The guide labels that single mismatch as the expected starting state before the learner edits anything (`chapters/01-getting-started/README.md:217-250`).

The root solution serves a different purpose. It includes the completed example, reference solution, and solution test only (`LetsStudyCS.slnx:2-10`), so a normal root build or test does not silently turn the exercise red.

## Guidance

Treat the learner path and repository acceptance path as two separate contracts.

1. Keep the deliberately incomplete practice app and its test out of the root solution.
2. Keep a completed reference app with a matching test inside the root solution.
3. Verify the committed practice state fails for the intended assertion, not because restore or compilation failed.
4. Verify the completed practice state in an isolated copy that preserves the app-to-test relative paths.
5. Delete the temporary copy after verification.

The root acceptance surface is:

```shell
dotnet restore LetsStudyCS.slnx
dotnet build LetsStudyCS.slnx --no-restore
dotnet test LetsStudyCS.slnx --no-build
```

The intended learner RED is checked independently:

```shell
dotnet test chapters/01-getting-started/tests/HelloWorld.Practice.Tests/HelloWorld.Practice.Tests.csproj
```

A valid RED reaches test execution and reports one `Assert.Equal` failure with expected `Hello, World!` and an empty actual value. A restore error, compiler error, missing project, or “no tests found” result does not prove the exercise contract.

To prove GREEN without changing the committed exercise, create a temporary tree containing both of these directories with their relationship intact:

```text
chapters/01-getting-started/practice/HelloWorld/
chapters/01-getting-started/tests/HelloWorld.Practice.Tests/
```

The test project points to the practice app through a relative `ProjectReference` (`chapters/01-getting-started/tests/HelloWorld.Practice.Tests/HelloWorld.Practice.Tests.csproj:17-19`). Copying only one project, or flattening the directories, tests a broken layout instead of the learner path.

Inside the temporary tree only, change the copied greeting to:

```csharp
return "Hello, World!";
```

Then run the copied test project and copied app. Require one passing test and exact `Hello, World!` output, and remove the temporary tree even if verification fails.

## Why This Matters

Putting an expected-red project in the root solution makes every fresh clone look broken. Making the committed practice implementation green avoids that problem but destroys the learner's first observation. Weakening the root test or testing only the already-complete reference solution creates a different failure: automation is green without proving that the actual learner project can become green.

The split keeps each signal honest:

- Root green means the checked-in reference baseline builds and passes.
- Practice red means the intended teaching assertion is active.
- Isolated practice green means the same learner project and test relationship succeeds after the intended edit.
- Cleanup means the proof did not mutate or contaminate the repository baseline.

The practice and solution projects look similar on purpose. Consolidating them into one shared implementation would couple the expected-red exercise to the always-green reference and erase the state boundary this convention protects.

## When to Apply

- A tutorial commits starter code that is supposed to fail one focused test.
- A kata or workshop needs a clean root build while individual exercises begin incomplete.
- A reference answer must remain available without changing the learner's starting files.
- CI or release checks need to distinguish an intentional assertion failure from infrastructure failure.

Do not use this pattern for accidental failures. Unexpected red tests belong in the root acceptance surface and must be fixed.

## Examples

### Root green, practice red

`LetsStudyCS.slnx` contains only the example, reference solution, and solution test (`LetsStudyCS.slnx:2-10`). The practice test instead targets the incomplete practice app directly (`chapters/01-getting-started/tests/HelloWorld.Practice.Tests/HelloWorld.Practice.Tests.csproj:17-19`).

### Isolated practice green

A maintainer copies the practice app and practice test into a temporary tree, preserving the `chapters/01-getting-started/practice/` and `chapters/01-getting-started/tests/` siblings. Only the copied `Greeting.cs` is completed. The copied test must pass once, and the copied app must print exactly `Hello, World!`. The original practice file remains empty, so the next learner still starts from RED.

### Learner-owned second cycle

After the first GREEN, the chapter asks the learner to change the expected value first, observe RED again, then change the implementation and observe GREEN (`chapters/01-getting-started/README.md:262-272`). This expectation-first order proves that the test is enforcing the learner's new promise rather than merely following an implementation that was already changed.

## Related

- `README.md` describes the repository-wide example, practice, solution, and test roles.
- `chapters/01-getting-started/README.md` contains the learner-facing red-green sequence.
- `docs/plans/2026-07-27-001-feat-csharp-chapter-01-plan.md` records the Chapter 1 acceptance contract and solution-isolation decision.
