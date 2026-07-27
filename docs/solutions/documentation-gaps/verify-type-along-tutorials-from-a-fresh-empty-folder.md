---
title: Verify type-along tutorials from a fresh empty folder
date: 2026-07-27
category: documentation-gaps
module: chapters/01-getting-started
problem_type: documentation_gap
component: documentation
severity: medium
applies_when:
  - "A tutorial asks learners to type commands or code instead of cloning a completed sample"
  - "Framework templates, project references, or generated file names are part of the learning path"
  - "An intended RED-to-GREEN result is presented as reproducible"
resolution_type: documentation_update
related_components:
  - development_workflow
  - testing_framework
  - tooling
tags:
  - type-along
  - reproducibility
  - fresh-scaffold
  - dotnet
  - xunit
  - red-green
---

# Verify type-along tutorials from a fresh empty folder

## Context

A prepared example proves that the checked-in files run. It does not prove that a learner can create those files by following the documentation.

A type-along guide has a larger executable contract: the starting directory, scaffold commands, generated file names, project wiring, code blocks, expected intermediate failure, permitted edit, and final output must all agree. Chapter 1 exposes that contract by asking the learner to create the console and xUnit projects in an empty folder, add the project reference, and complete a RED-GREEN cycle (`README.md:77-98`).

This complements root-solution isolation rather than replacing it. The existing convention keeps deliberately incomplete practice code outside the always-green root solution (`docs/solutions/conventions/isolate-intentionally-failing-practice-tests.md:29-39`). Clean-room documentation verification asks a different question: can the instructions alone recreate the intended project and behavior without copying prepared practice files?

## Guidance

Treat the guide as an executable acceptance path.

1. Start in a genuinely empty folder. Record that location so commands cannot accidentally run against prepared repository files. Chapter 1 makes the starting boundary explicit (`chapters/01-getting-started/README.md:114-120`).
2. Create the documented `global.json` and run `dotnet --version` again inside the empty folder. Require a `10.0` result to exclude a newer major SDK, and record the full resolved version. The `latestFeature` policy accepts later .NET 10 feature bands and patches, so repeat the clean-room walkthrough whenever that full version changes (`chapters/01-getting-started/README.md:122-129`).
3. Run the documented scaffold commands verbatim. For Chapter 1, this creates the .NET 10 console and xUnit projects (`chapters/01-getting-started/README.md:131-156`, `chapters/01-getting-started/README.md:198-225`).
4. Check the generated tree before editing. A successful command that creates files under the wrong path is not a successful walkthrough.
5. Run the documented project-reference command and inspect the result. The checked-in test project expresses the required relationship through its relative `ProjectReference` (`chapters/01-getting-started/tests/HelloWorld.Practice.Tests/HelloWorld.Practice.Tests.csproj:17-19`).
6. Transcribe the documented code blocks instead of copying repository files. Confirm that the resulting file manifest matches the guide (`chapters/01-getting-started/README.md:251-321`).
7. Verify the quality of RED, not merely a non-zero exit. The expected state reaches xUnit and reports the greeting mismatch: expected `Hello, World!`, actual empty text (`chapters/01-getting-started/README.md:323-338`). The checked-in exercise contains one `[Fact]`, one `Assert.Equal`, and an empty practice result (`chapters/01-getting-started/tests/HelloWorld.Practice.Tests/GreetingTests.cs:3-6`, `chapters/01-getting-started/practice/HelloWorld/Greeting.cs:5`).
8. Apply only the edit named by the guide. Chapter 1 changes `return "";` to `return "Hello, World!";` (`chapters/01-getting-started/README.md:340-352`). Extra repairs can hide a missing instruction.
9. Re-run the same test and app. Require one passing test and the exact `Hello, World!` output (`chapters/01-getting-started/README.md:354-370`).
10. Remove the clean-room folder afterward so a later run cannot reuse generated or edited files.

Keep a short transcript tied to the guide revision. It should capture the starting directory, full resolved SDK version, commands, observed tree, project reference, RED assertion, sole edit, passing-test count, and final standard output.

## Why This Matters

Prepared files can stay green while the teaching path silently breaks. A renamed template file, missing `ProjectReference`, stale output path, incomplete code block, or undocumented repair is invisible when maintainers test only files already in the repository.

The fresh-folder run exercises the same dependencies the learner encounters. Structure checks expose path drift, reference inspection separates project wiring from C# behavior, and assertion-level RED proves the test was discovered for the promised reason. Restricting GREEN to the documented edit proves that the guide contains a sufficient recovery path rather than relying on maintainer knowledge.

Repository validation and clean-room guide validation protect different things:

- Repository tests protect committed artifacts.
- Clean-room reconstruction protects the learner journey.
- Intended-RED isolation protects the always-green root acceptance surface.

All three checks are needed when a tutorial commits deliberately incomplete practice code.

## When to Apply

- A tutorial tells readers to type code or CLI commands.
- A framework template generates starter files or package references.
- Two or more projects are connected through relative paths or references.
- An intentional failure must be distinguished from restore, compilation, or test-discovery failures.
- The acceptance contract includes an exact test count, assertion message, file tree, or console output.
- An SDK, package, command, path, generated filename, or documented code block changes.

## Examples

Repository-only verification is insufficient:

```shell
dotnet test LetsStudyCS.slnx
dotnet run --project chapters/01-getting-started/examples/HelloWorld/HelloWorld.csproj
```

Those commands validate prepared files, but do not prove that the learner can create and connect the projects.

A clean-room Chapter 1 check starts with the documented creation path:

```shell
dotnet new globaljson --sdk-version 10.0.100 --roll-forward latestFeature
dotnet --version
dotnet new console --output chapters/01-getting-started/practice/HelloWorld --framework net10.0
dotnet new xunit --output chapters/01-getting-started/tests/HelloWorld.Practice.Tests --framework net10.0
dotnet add chapters/01-getting-started/tests/HelloWorld.Practice.Tests/HelloWorld.Practice.Tests.csproj reference chapters/01-getting-started/practice/HelloWorld/HelloWorld.csproj
dotnet list chapters/01-getting-started/tests/HelloWorld.Practice.Tests/HelloWorld.Practice.Tests.csproj reference
```

After running the entire guide, record the observed results with this template:

```text
START: empty folder
SDK: dotnet --version = <full 10.0.x version>
SCAFFOLD: console and xUnit commands succeeded
STRUCTURE: expected app and test files present
REFERENCE: practice HelloWorld project listed
RED: 1 test failed; Expected "Hello, World!"; Actual ""
EDIT: Greeting.cs return value only
GREEN: 1 test passed
RUN: Hello, World!
```

A completed record in this format demonstrates that the documentation is reproducible, not merely that the committed sample is executable.

## Related

- `docs/solutions/conventions/isolate-intentionally-failing-practice-tests.md` explains how to keep learner RED separate from the root green solution.
- `chapters/01-getting-started/README.md` is the learner-facing type-along path.
- `docs/plans/2026-07-27-001-feat-csharp-chapter-01-plan.md:350-380` records the repository and learning-path verification contracts.
