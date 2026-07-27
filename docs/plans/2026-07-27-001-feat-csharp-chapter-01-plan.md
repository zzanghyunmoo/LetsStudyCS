---
title: C# Chapter 1 - First Program - Plan
type: feat
date: 2026-07-27
artifact_contract: ce-unified-plan/v1
artifact_readiness: implementation-ready
product_contract_source: ce-plan-bootstrap
execution: code
---

# C# Chapter 1 - First Program - Plan

## Goal Capsule

프로그래밍을 처음 접하는 학습자가 C#을 배우는 이유를 이해하고, 자신의 컴퓨터에서 .NET 개발 환경을 확인한 뒤, `Hello, World!` 프로그램과 첫 xUnit 테스트를 직접 실행한다. 1장은 문법 수업을 시작하기 전의 진입 장벽을 낮추는 장이며, 변수·조건문·반복문과 게임 구현은 2장부터 다룬다.

---

## Product Contract

### Audience and problem

- 대상은 프로그래밍과 C# 경험이 없는 완전 초심자다.
- 용어를 이미 안다고 가정하지 않는다. SDK, 터미널, 프로젝트, 테스트 같은 단어는 처음 등장할 때 한 문장으로 설명한다.
- 설치 안내만 길게 이어지지 않도록, 환경 확인 직후 실행 가능한 결과를 보여준다.
- 복사만 하고 끝내지 않도록 각 단계는 읽기, 예측하기, 완성하기, 직접 만들기의 흐름을 따른다.

### Requirements

R1. 학습자는 프로그래밍을 배우면 어떤 문제를 해결할 수 있는지 일상적인 예시로 이해한다.

R2. 학습자는 C#과 .NET의 관계, C#을 첫 언어로 선택할 만한 이유, 이 과정에서 C#을 사용하는 이유를 과장 없이 이해한다.

R3. 학습자는 .NET 10 SDK, Visual Studio Code, C# Dev Kit을 준비하고 `dotnet --version`으로 설치 상태를 확인한다.

R4. Windows는 본문에서 단계별로 안내하고, macOS와 Linux는 같은 검증 기준과 공식 설치 문서 경로를 제공한다.

R5. 학습자는 CLI에서 콘솔 프로젝트를 만들고 실행하는 흐름을 이해하며, 저장소의 완성 예제를 실행해 정확히 `Hello, World!`를 확인한다.

R6. 첫 예제는 .NET 10 콘솔 템플릿의 top-level statements 형태를 유지한다. `Main`, 클래스, 네임스페이스 문법은 이 장에서 선행 설명하지 않는다.

R7. 학습자는 xUnit의 `[Fact]`, `Assert.Equal`, expected, actual의 역할을 최소 용어로 이해한다.

R8. 첫 테스트는 콘솔 출력 가로채기가 아니라 실제 앱이 사용하는 인사말 생성 동작을 검증한다.

R9. 연습용 테스트는 처음에 실패하고, 학습자가 인사말 동작을 완성하면 통과한다. 정답 프로젝트와 정답 테스트는 저장소 기준 상태에서 항상 통과한다.

R10. 예제, 연습, 정답, 테스트는 분리하며 1장에는 `game/` 디렉터리를 만들지 않는다.

### Learning flow

1. 읽기: 프로그래밍과 C#을 배우는 이유, 개발 도구의 역할을 읽는다.
2. 예측하기: 첫 프로그램을 실행하기 전에 출력될 한 줄을 적어 본다.
3. 완성하기: 실패하는 xUnit 테스트를 확인하고 인사말 동작을 완성해 테스트를 통과시킨다.
4. 직접 만들기: 인사말과 기대값을 자신의 문장으로 바꾸어 실패와 통과를 한 번 더 경험한다.

### Acceptance examples

AE1. .NET 10 SDK가 준비된 환경에서 학습자가 저장소 루트에서 버전 확인 명령을 실행하면 `10.0`으로 시작하는 SDK 버전을 볼 수 있다.

AE2. 학습자가 완성 예제를 실행하면 추가 안내 문구 없이 `Hello, World!` 한 줄이 출력되고 프로세스가 성공 종료한다.

AE3. 학습자가 수정 전 연습 테스트를 실행하면 인사말 테스트 한 개가 실패하고, 실패 메시지에서 기대값 `Hello, World!`와 실제 빈 값의 차이를 확인할 수 있다.

AE4. 학습자가 연습 앱의 인사말 동작을 완성한 뒤 같은 테스트를 다시 실행하면 테스트가 통과한다.

AE5. 저장소 루트의 복원, 빌드, 테스트 명령은 연습용 실패 테스트를 제외한 기준 프로젝트를 대상으로 모두 성공한다.

### In scope

- 프로그래밍을 배우는 이유와 C#을 선택하는 이유
- C#, .NET, SDK의 최소 개념
- .NET 10 SDK와 VS Code 기반 개발 환경 준비
- 터미널 열기, 버전 확인, `dotnet new console`, `dotnet run`
- top-level statements 기반 Hello World
- xUnit의 첫 `[Fact]`와 `Assert.Equal`
- red-green 한 번을 경험하는 작은 인사말 연습
- 설치 및 실행 문제에 대한 짧은 복구 안내

### Out of scope

- 변수, 자료형, 연산자, 조건문, 반복문의 정식 설명
- 클래스, `static`, 메서드, 네임스페이스의 문법 수업
- 게임 프로젝트 또는 게임 규칙
- Git 사용법, CI 구성, 디버거 심화 사용법
- 콘솔 출력 캡처나 mocking 도구
- NUnit, MSTest, xUnit v3, Microsoft Testing Platform 비교
- Windows, macOS, Linux 각각에 대한 장문의 독립 설치 튜토리얼

---

## Planning Contract

### Current repository state

- `README.md`만 남긴 초기화 상태이며 기존 구현 관례는 없다.
- `README.md`는 .NET 10, C# 14, xUnit과 `examples/`, `practice/`, `solution/`, `tests/` 분리를 프로젝트 계약으로 선언한다.
- 1장은 게임 없이 시작하고 본격적인 C# 문법과 게임 구현은 2장부터 진행한다.

### Key technical decisions

KTD1. 저장소 SDK 기준은 `global.json`의 .NET `10.0.100`과 `latestFeature` roll-forward로 표현한다. .NET 10이라는 학습 기준은 고정하면서, 설치된 최신 10.0 기능 밴드 SDK를 사용할 수 있게 한다.

KTD2. 루트 솔루션은 .NET 10 기본 형식인 `LetsStudyCS.slnx`를 사용한다. 솔루션에는 완성 예제, 정답 앱, 정답 테스트만 포함해 새로 clone한 기준 상태가 항상 green이 되게 한다.

KTD3. 연습 앱과 연습 테스트는 루트 솔루션에서 제외한다. 연습 테스트의 의도된 red 상태가 전체 저장소 검증을 깨뜨리지 않으면서도 학습자는 해당 테스트 프로젝트를 직접 실행할 수 있다.

KTD4. 읽기 예제는 템플릿 그대로의 top-level statements를 사용한다. 연습과 정답에는 테스트 가능한 작은 인사말 생성 동작을 제공하고, 콘솔 앱은 그 결과를 출력한다.

KTD5. 테스트를 위해 제공되는 클래스와 `public static` 메서드는 이 장에서 외워야 할 문법이 아니라 “테스트할 수 있도록 미리 준비한 인사말 기능”으로 소개한다. 문법 설명은 후속 장으로 미룬다.

KTD6. xUnit 프로젝트는 .NET 10 SDK의 `xunit` 템플릿이 생성하는 xUnit v2 계열 구성을 따른다. 초심자 장에서 v3와 Microsoft Testing Platform 전환 선택지를 추가하지 않는다.

KTD7. Windows 설치는 본문 주 경로로 작성한다. macOS와 Linux는 공식 설치 문서 링크, 같은 `dotnet --version` 완료 기준, 공통 CLI 실습을 제공한다.

### Target structure

```text
.
├── .gitignore
├── .vscode/
│   └── extensions.json
├── global.json
├── LetsStudyCS.slnx
├── README.md
└── chapters/
    └── 01-getting-started/
        ├── README.md
        ├── examples/
        │   └── HelloWorld/
        │       ├── HelloWorld.csproj
        │       └── Program.cs
        ├── practice/
        │   └── HelloWorld/
        │       ├── Greeting.cs
        │       ├── HelloWorld.csproj
        │       └── Program.cs
        ├── solution/
        │   └── HelloWorld/
        │       ├── Greeting.cs
        │       ├── HelloWorld.csproj
        │       └── Program.cs
        └── tests/
            ├── HelloWorld.Practice.Tests/
            │   ├── GreetingTests.cs
            │   └── HelloWorld.Practice.Tests.csproj
            └── HelloWorld.Solution.Tests/
                ├── GreetingTests.cs
                └── HelloWorld.Solution.Tests.csproj
```

### Content design

- 장 본문은 “왜 배우나요?”, “무엇을 설치하나요?”, “첫 프로그램 실행”, “첫 테스트 실행”, “막혔을 때”, “완료 체크” 순서로 구성한다.
- 명령마다 실행 위치와 성공 시 관찰할 결과를 함께 적는다.
- 예제 명령은 저장소 경로와 직접 만든 임시 프로젝트 경로를 혼동하지 않도록 구분한다.
- 설치 실패 복구는 SDK와 Runtime의 차이, 터미널 재시작, VS Code 프로젝트 다시 열기, `dotnet --version` 미인식까지만 다룬다.
- 각 절의 마지막에는 다음 행동 하나만 제시해 초심자가 갈림길을 고르지 않게 한다.

### Risks and mitigations

- 최신 SDK 패치 차이: `global.json`은 .NET 10 범위에서 roll-forward하고, 문서는 정확한 패치 번호가 아닌 `10.0` 접두사를 완료 기준으로 사용한다.
- VS Code에서 프로젝트 미인식: C# Dev Kit 설치 여부와 장 폴더가 아닌 저장소 루트를 연 상태인지 확인하는 복구 절차를 제공한다.
- 연습용 red 테스트를 저장소 결함으로 오해: 장 본문과 테스트 프로젝트 README 역할을 하는 주석에서 “처음에는 실패하는 것이 정상”을 실행 전에 명시한다.
- 아직 배우지 않은 문법 노출: 제공된 테스트 가능 구조는 수정 지점을 한 곳으로 제한하고, 클래스와 메서드의 정식 설명은 2장 이후로 연결한다.
- CLI와 편집기 작업 혼동: 모든 필수 성공 기준은 CLI로 검증하고 VS Code 버튼은 보조 경로로만 설명한다.

### Sources

- [.NET CLI overview](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet)
- [.NET SDK templates](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-new-sdk-templates)
- [C# top-level statements](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/top-level-statements)
- [C# Hello World tutorial](https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/hello-world)
- [Get started with C# in VS Code](https://code.visualstudio.com/docs/csharp/get-started)
- [Unit testing C# with xUnit](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-csharp-with-xunit)
- [Testing with the .NET CLI](https://learn.microsoft.com/en-us/dotnet/core/tutorials/testing-with-cli)
- [xUnit.net v2 getting started](https://xunit.net/docs/getting-started/v2/getting-started)
- [.NET installation guides](https://learn.microsoft.com/en-us/dotnet/core/install/)

---

## Implementation Units

### U1. Establish the .NET 10 workspace baseline

**Goal:** 모든 후속 예제와 검증이 같은 SDK 및 솔루션 기준에서 실행되게 한다.

**Requirements:** R3, R10

**Files:**

- Create `global.json`
- Create `LetsStudyCS.slnx`
- Create `.gitignore`
- Create `.vscode/extensions.json`

**Approach:**

- `global.json`은 KTD1의 SDK 기준을 적용한다.
- `.gitignore`는 .NET 빌드 산출물, 테스트 결과, Visual Studio와 사용자별 파일만 제외한다.
- VS Code 추천 확장은 C# Dev Kit 하나로 제한한다.
- 솔루션은 이후 단위에서 완성 예제와 green 정답 경로만 추가할 수 있는 빈 기준으로 만든다.

**Test scenarios:**

- .NET 10 SDK가 설치된 환경에서 저장소 루트의 `dotnet --version`은 `10.0`으로 시작한다.
- 솔루션을 열거나 목록을 조회할 때 형식 오류가 없다.
- 빌드 후 생성되는 `bin/`, `obj/`, `TestResults/`가 Git 변경으로 나타나지 않는다.

**Dependencies:** 없음

**Verification:** SDK 해석이 .NET 10으로 고정되고, 솔루션과 편집기 권장 설정이 오류 없이 읽힌다.

### U2. Write the chapter guide and complete Hello World example

**Goal:** 학습자가 C#을 선택한 이유를 이해하고 환경을 확인한 뒤 첫 프로그램을 예측하고 실행한다.

**Requirements:** R1, R2, R3, R4, R5, R6

**Files:**

- Create `chapters/01-getting-started/README.md`
- Create `chapters/01-getting-started/examples/HelloWorld/HelloWorld.csproj`
- Create `chapters/01-getting-started/examples/HelloWorld/Program.cs`
- Modify `LetsStudyCS.slnx`

**Approach:**

- Product Contract의 학습 흐름과 Content design 순서로 본문을 작성한다.
- C#을 선택하는 이유는 읽기 쉬운 문법, 정적 타입의 도움, .NET 도구 생태계, 여러 운영체제와 다양한 앱 유형을 다룰 수 있다는 점으로 설명한다.
- SDK와 Runtime의 차이는 “만드는 도구 상자”와 “실행에 필요한 구성” 수준의 짧은 비유로 설명한다.
- Windows 설치 절차 뒤에 macOS와 Linux 공식 문서와 동일한 완료 기준을 배치한다.
- 예제는 .NET 10 콘솔 템플릿의 top-level statements 한 줄 형태를 유지한다.
- 실행 전 출력 예측 칸과 실행 후 관찰 체크를 제공한다.

**Test scenarios:**

- 깨끗한 터미널에서 예제 프로젝트를 실행하면 표준 출력이 정확히 `Hello, World!` 한 줄이다.
- 본문에 나온 모든 저장소 내부 링크와 예제 경로가 실제 파일을 가리킨다.
- Windows, macOS, Linux 각각에 공식 설치 경로와 공통 버전 확인 명령이 있다.
- `Main`, 변수, 조건문, 반복문을 알아야만 진행할 수 있는 설명이나 과제가 없다.

**Dependencies:** U1

**Verification:** 초심자가 본문 순서만 따라 SDK 확인과 예제 실행을 완료하고 AE1, AE2를 관찰할 수 있다.

### U3. Add the intentionally failing practice path

**Goal:** 학습자가 첫 xUnit 테스트를 읽고 red 상태를 확인한 뒤 실제 앱의 인사말 동작을 완성한다.

**Requirements:** R7, R8, R9, R10

**Files:**

- Create `chapters/01-getting-started/practice/HelloWorld/HelloWorld.csproj`
- Create `chapters/01-getting-started/practice/HelloWorld/Program.cs`
- Create `chapters/01-getting-started/practice/HelloWorld/Greeting.cs`
- Create `chapters/01-getting-started/tests/HelloWorld.Practice.Tests/HelloWorld.Practice.Tests.csproj`
- Create `chapters/01-getting-started/tests/HelloWorld.Practice.Tests/GreetingTests.cs`
- Modify `chapters/01-getting-started/README.md`

**Approach:**

- 연습 앱의 진입점은 제공된 인사말 생성 동작을 호출해 그 결과를 출력한다.
- 수정 전 인사말 동작은 컴파일되지만 빈 값을 반환하도록 두어 테스트가 예상 가능한 이유로 실패하게 한다.
- 테스트 프로젝트는 연습 앱을 직접 참조하고, `[Fact]` 하나와 `Assert.Equal` 하나로 `Hello, World!`를 검증한다.
- 본문은 테스트 실행 전에 실패가 정상임을 명시하고 expected와 actual만 설명한다.
- 첫 red-green 뒤에는 인사말과 기대값을 자신의 문장으로 함께 바꾸어 두 번째 red-green을 스스로 만들어 보게 한다.
- KTD3에 따라 연습 앱과 연습 테스트를 루트 솔루션에 추가하지 않는다.

**Test scenarios:**

- 수정 전 연습 앱과 테스트 프로젝트는 모두 컴파일된다.
- 수정 전 연습 테스트는 인사말 테스트 한 개 때문에 실패하며 다른 설정 오류는 없다.
- 실패 결과는 기대값 `Hello, World!`와 빈 실제 값을 보여준다.
- 인사말 동작을 요구사항대로 완성한 작업 사본에서는 같은 테스트가 통과하고 앱도 `Hello, World!`를 출력한다.
- 루트 솔루션 검증에는 의도적으로 실패하는 연습 테스트가 포함되지 않는다.

**Dependencies:** U1, U2

**Verification:** 저장소 기준 red 상태와 학습자 수정 후 green 상태가 모두 재현되며 AE3, AE4를 충족한다.

### U4. Add the green reference solution

**Goal:** 학습자와 유지보수자가 연습의 정답 및 테스트 가능한 기준 구현을 확인할 수 있게 한다.

**Requirements:** R5, R7, R8, R9, R10

**Files:**

- Create `chapters/01-getting-started/solution/HelloWorld/HelloWorld.csproj`
- Create `chapters/01-getting-started/solution/HelloWorld/Program.cs`
- Create `chapters/01-getting-started/solution/HelloWorld/Greeting.cs`
- Create `chapters/01-getting-started/tests/HelloWorld.Solution.Tests/HelloWorld.Solution.Tests.csproj`
- Create `chapters/01-getting-started/tests/HelloWorld.Solution.Tests/GreetingTests.cs`
- Modify `LetsStudyCS.slnx`
- Modify `chapters/01-getting-started/README.md`

**Approach:**

- 정답 앱은 연습 앱과 같은 파일 역할과 흐름을 유지하고 인사말 동작만 완성한다.
- 정답 테스트는 연습 테스트와 같은 이름과 기대 동작을 사용해 비교가 쉽도록 한다.
- 정답 앱과 정답 테스트를 루트 솔루션에 추가한다.
- 장 본문은 시도하기 전 정답을 열지 않도록 안내하되, 막혔을 때 비교할 정확한 파일을 알려준다.

**Test scenarios:**

- 정답 앱 실행 결과가 정확히 `Hello, World!` 한 줄이다.
- 정답 테스트 프로젝트의 테스트가 한 개 이상 발견되고 모두 통과한다.
- 테스트가 실제 정답 앱 프로젝트를 참조하며 테스트 안에 생산 동작을 복제하지 않는다.
- 연습과 정답의 차이는 학습 목표와 관련된 최소 변경으로 제한된다.

**Dependencies:** U3

**Verification:** 정답 앱과 테스트가 독립적으로 green이며 연습의 복구 기준으로 사용할 수 있다.

### U5. Integrate navigation and end-to-end verification

**Goal:** 저장소 첫 화면에서 1장으로 이동할 수 있고, 문서의 모든 실행 약속이 실제 프로젝트 상태와 일치하게 한다.

**Requirements:** R1, R3, R5, R9, R10

**Files:**

- Modify `README.md`
- Modify `chapters/01-getting-started/README.md`
- Modify `LetsStudyCS.slnx`

**Approach:**

- 루트 README의 1장 계획 항목을 실제 장 링크와 실행 가능한 시작점으로 갱신한다.
- 장 끝에 완료 체크리스트와 2장 예고를 추가한다.
- 명령의 실행 위치, 예상 출력, 의도된 실패와 실제 오류를 구분하는 복구 표를 최종 점검한다.
- 저장소 트리와 문서 예시에서 1장 `game/`이 존재하는 것처럼 보이는 표현을 제거한다.

**Test scenarios:**

- 루트 README에서 한 번의 링크로 1장 본문에 도달한다.
- 문서에 적힌 모든 내부 경로가 존재하고 모든 필수 명령이 해당 위치에서 실행된다.
- 루트 솔루션은 예제, 정답 앱, 정답 테스트만 포함하고 복원, 빌드, 테스트가 모두 성공한다.
- `chapters/01-getting-started/` 아래에 `game/` 디렉터리가 없다.
- 완료 체크리스트는 버전 확인, 예제 출력, 의도된 테스트 실패, 수정 후 테스트 통과를 모두 포함한다.

**Dependencies:** U1, U2, U3, U4

**Verification:** 새 학습자가 루트 README에서 시작해 1장 완료 체크까지 끊김 없이 진행할 수 있고 AE5를 충족한다.

---

## Verification Contract

### Automated gates

저장소 루트에서 다음 순서로 검증한다.

1. `dotnet --version`
   - 성공 기준: 출력이 `10.0`으로 시작한다.
2. `dotnet restore LetsStudyCS.slnx`
   - 성공 기준: 모든 기준 프로젝트가 복원되고 오류가 없다.
3. `dotnet build LetsStudyCS.slnx --no-restore`
   - 성공 기준: 경고를 새로 만들지 않고 빌드가 성공한다.
4. `dotnet test LetsStudyCS.slnx --no-build`
   - 성공 기준: 정답 테스트가 발견되고 모두 통과한다.
5. `dotnet run --project chapters/01-getting-started/examples/HelloWorld/HelloWorld.csproj`
   - 성공 기준: 표준 출력이 `Hello, World!` 한 줄이다.
6. `dotnet run --project chapters/01-getting-started/solution/HelloWorld/HelloWorld.csproj`
   - 성공 기준: 표준 출력이 `Hello, World!` 한 줄이다.
7. `dotnet test chapters/01-getting-started/tests/HelloWorld.Solution.Tests/HelloWorld.Solution.Tests.csproj`
   - 성공 기준: 테스트가 한 개 이상 발견되고 모두 통과한다.
8. `dotnet test chapters/01-getting-started/tests/HelloWorld.Practice.Tests/HelloWorld.Practice.Tests.csproj`
   - 저장소 기준 성공 조건: 명령은 설정 오류 없이 테스트까지 도달하고, 지정된 인사말 테스트 한 개만 기대값 불일치로 실패한다.
9. 연습 앱과 `HelloWorld.Practice.Tests`를 상대 경로가 유지되는 하나의 임시 트리에 복사하고, 복사본의 인사말 동작을 완성한 뒤 복사된 테스트 프로젝트를 실행한다.
   - 성공 기준: 복사본의 같은 테스트가 통과하고 원본 저장소의 의도된 red 상태는 유지된다.
10. `git diff --check`
    - 성공 기준: 공백 오류가 없다.

### Manual learning-path QA

- Windows 초심자 시점으로 루트 README부터 1장 완료 체크까지 순서대로 따라간다.
- 각 명령 전에 실행 위치가 명확한지, 실행 후 관찰할 결과가 바로 이어지는지 확인한다.
- 코드 설명이 아직 배우지 않은 문법 이해를 요구하지 않는지 확인한다.
- 의도된 테스트 실패와 설치·복원·컴파일 오류를 초심자가 구분할 수 있는지 확인한다.
- macOS와 Linux 독자가 공식 설치 경로를 찾고 같은 CLI 단계로 합류할 수 있는지 확인한다.
- 모든 외부 링크가 공식 Microsoft, VS Code, xUnit 문서로 연결되는지 확인한다.

### Traceability

- AE1: U1, U2 및 자동화 게이트 1
- AE2: U2 및 자동화 게이트 5
- AE3: U3 및 자동화 게이트 8
- AE4: U3 및 자동화 게이트 9
- AE5: U1, U4, U5 및 자동화 게이트 2-4

---

## Definition of Done

- R1-R10이 하나 이상의 구현 단위와 검증 시나리오에 연결되어 있다.
- `chapters/01-getting-started/README.md`가 왜 프로그래밍과 C#을 배우는지부터 첫 xUnit red-green까지 한 흐름으로 안내한다.
- .NET 10 SDK, VS Code, C# Dev Kit의 설치와 확인 경로가 초심자에게 명확하다.
- Hello World 예제와 정답 앱은 정확히 `Hello, World!`를 출력한다.
- 첫 xUnit 테스트는 실제 앱이 사용하는 인사말 동작을 검증한다.
- 연습 테스트의 의도된 red 상태와 완성 후 green 상태가 각각 검증된다.
- 루트 솔루션 복원, 빌드, 테스트가 모두 성공한다.
- 예제, 연습, 정답, 테스트가 계획된 디렉터리로 분리되어 있다.
- 1장에 게임 구현과 정식 문법 수업이 들어가지 않는다.
- 루트 README가 실제 1장 문서로 연결되고 모든 내부 링크가 유효하다.
- 공식 문서 외부 링크와 Windows, macOS, Linux 진입 경로가 수동 점검되었다.
- 생성 산출물과 임시 검증 사본이 Git 추적 대상에 남지 않고 `git diff --check`가 통과한다.

---

## Appendix

### Planned chapter boundary

1장의 마지막 문장은 “이제 코드를 실행하고 테스트로 확인하는 방법을 알았다”는 성취를 확인한다. 2장은 변수와 값을 사용해 게임의 첫 상태를 표현하는 것으로 시작하며, 1장에서 제공만 했던 메서드와 타입 문법은 필요해지는 시점에 설명한다.
