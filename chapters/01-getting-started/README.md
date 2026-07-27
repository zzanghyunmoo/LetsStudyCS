# 1장: C#과 첫 프로그램

이 장은 프로그래밍을 처음 접하는 사람을 위한 출발점입니다. 어려운 문법을 외우기 전에 개발 도구를 준비하고, 작은 프로그램을 직접 실행해 봅니다.

## 이번 장의 목표

이 장을 마치면 다음을 할 수 있습니다.

- 프로그래밍을 배우는 이유를 자신의 말로 설명합니다.
- C#과 .NET이 각각 무엇인지 구분합니다.
- .NET 10 SDK, Visual Studio Code, C# Dev Kit을 준비합니다.
- 터미널에서 `dotnet` 명령을 실행합니다.
- `Hello, World!` 프로그램을 예측하고 실행합니다.
- 아직 배우지 않은 문법을 만나도 제공된 안내를 따라 실행 결과를 확인합니다.

> 변수, 조건문, 반복문과 게임 구현은 2장부터 시작합니다.

## 1. 왜 프로그래밍을 배우나요?

프로그래밍은 해결하고 싶은 일을 컴퓨터가 실행할 수 있는 작은 단계로 표현하는 방법입니다.

예를 들어 매일 반복해서 파일 이름을 정리하거나, 점수를 계산하거나, 게임 속 블록을 움직이는 일을 사람이 계속 수행할 필요는 없습니다. 규칙을 정확히 코드로 작성하면 컴퓨터가 같은 일을 빠르고 일관되게 반복할 수 있습니다.

프로그래밍을 배우면서 다음 습관도 함께 익힙니다.

- 큰 문제를 작은 단계로 나누기
- 예상과 실제 결과를 비교하기
- 실패 원인을 한 번에 하나씩 확인하기
- 느낌이 아니라 실행 결과로 답을 검증하기

이 저장소에서도 설명을 읽는 데서 끝내지 않습니다. 실행 전에 결과를 예측하고, 직접 실행하고, 나중에는 테스트로 동작을 확인합니다.

## 2. 왜 C#인가요?

C#은 코드를 사람이 읽기 쉽게 표현하면서도, 잘못된 코드를 실행 전에 발견하도록 도와주는 현대적인 프로그래밍 언어입니다.

첫 언어로 C#을 선택한 이유는 다음과 같습니다.

- 문법이 비교적 명확해서 코드의 의도를 따라가기 좋습니다.
- 잘못된 값이나 표현을 개발 도구가 일찍 알려 줍니다.
- 콘솔 프로그램, 웹, 클라우드, 데스크톱, 게임 등으로 학습을 이어갈 수 있습니다.
- .NET 도구가 프로젝트 생성, 실행, 테스트를 일관된 명령으로 지원합니다.
- Windows, macOS, Linux에서 같은 C# 프로젝트를 다룰 수 있습니다.

C#만이 좋은 언어라는 뜻은 아닙니다. 이 과정에서는 한 언어에 집중해 프로그래밍의 기본 원리를 익히고, 그 결과가 눈에 보이는 콘솔 게임까지 이어가기 위해 C#을 선택했습니다.

## 3. C#과 .NET은 어떻게 다른가요?

- **C#**은 우리가 코드를 작성할 때 사용하는 언어입니다.
- **.NET**은 C# 프로그램을 만들고 실행하는 데 필요한 도구와 실행 환경을 제공합니다.
- **SDK**는 새 프로젝트를 만들고, 코드를 빌드하고, 테스트하는 도구 상자입니다.
- **Runtime**은 이미 만들어진 .NET 프로그램을 실행하는 데 필요한 구성입니다.

이 과정에서는 코드를 직접 만들기 때문에 Runtime만이 아니라 **.NET 10 SDK**가 필요합니다.

## 4. 개발 환경 준비

이 과정의 기본 편집기는 Visual Studio Code입니다. 코드 실행과 검증은 운영체제에 관계없이 `dotnet` 명령을 기준으로 설명합니다.

### Windows

1. [.NET 10 다운로드 페이지](https://dotnet.microsoft.com/download/dotnet/10.0)를 엽니다.
2. **SDK 10.0**의 Windows x64 설치 프로그램을 내려받아 실행합니다.
3. [Visual Studio Code](https://code.visualstudio.com/download)를 설치합니다.
4. Visual Studio Code를 실행하고 왼쪽의 Extensions 아이콘을 선택합니다.
5. `C# Dev Kit`을 검색해 Microsoft가 게시한 확장을 설치합니다.
6. 설치 전에 열려 있던 터미널이 있다면 모두 닫고 새 터미널을 엽니다.

Windows on Arm 장치를 사용한다면 x64 대신 Arm64 SDK를 선택합니다.

### macOS

1. [Microsoft의 macOS용 .NET 설치 안내](https://learn.microsoft.com/dotnet/core/install/macos)를 따라 장치에 맞는 .NET 10 SDK를 설치합니다.
2. [Visual Studio Code](https://code.visualstudio.com/download)를 설치합니다.
3. Visual Studio Code에서 Microsoft의 C# Dev Kit을 설치합니다.

### Linux

1. [Microsoft의 Linux용 .NET 설치 안내](https://learn.microsoft.com/dotnet/core/install/linux)를 열고 사용하는 배포판을 선택합니다.
2. 해당 배포판 안내에 따라 .NET 10 SDK를 설치합니다.
3. [Visual Studio Code의 Linux 설치 안내](https://code.visualstudio.com/docs/setup/linux)를 따라 편집기를 설치합니다.
4. Visual Studio Code에서 Microsoft의 C# Dev Kit을 설치합니다.

설치 방법은 운영체제마다 다르지만, 다음 절부터 사용하는 명령과 완료 기준은 같습니다.

## 5. 터미널 열기와 SDK 확인

**터미널**은 글자로 명령을 입력하고 결과를 확인하는 창입니다.

Visual Studio Code에서 이 저장소의 루트 폴더를 연 뒤 상단 메뉴에서 **Terminal → New Terminal**을 선택합니다. 프롬프트 뒤에 다음 명령을 입력하세요.

```shell
dotnet --version
```

성공하면 다음처럼 `10.0`으로 시작하는 버전이 나타납니다. 마지막 숫자는 설치 시점에 따라 달라도 괜찮습니다.

```text
10.0.301
```

### 명령을 찾을 수 없다고 나오나요?

다음 순서로 확인합니다.

1. 열려 있던 터미널과 Visual Studio Code를 완전히 닫고 다시 엽니다.
2. Runtime이 아니라 **SDK**를 설치했는지 확인합니다.
3. 새 터미널에서 `dotnet --version`을 다시 실행합니다.
4. 그래도 해결되지 않으면 운영체제별 공식 설치 안내의 환경 변수 문제 해결 절차를 확인합니다.

버전이 `10.0`으로 시작하지 않는다면 .NET 10 SDK를 설치한 뒤 다시 확인합니다.

## 6. 콘솔 프로젝트는 무엇인가요?

**프로젝트**는 프로그램을 만드는 데 필요한 코드와 설정을 한곳에 모은 폴더입니다.

**콘솔 프로그램**은 터미널에서 글자를 입력받거나 출력하는 프로그램입니다. 첫 프로젝트를 직접 만들어 보고 싶다면 학습 저장소 밖의 빈 폴더에서 다음 명령을 차례로 실행할 수 있습니다.

```shell
mkdir MyFirstCSharp
cd MyFirstCSharp
dotnet new console
dotnet run
```

- `dotnet new console`은 새 콘솔 프로젝트를 만듭니다.
- `dotnet run`은 현재 프로젝트를 빌드하고 실행합니다.

이제 저장소에 준비된 같은 형태의 예제를 읽고 실행해 봅니다.

## 7. 읽기: 첫 C# 코드

[첫 예제의 `Program.cs`](examples/HelloWorld/Program.cs)를 열어 보세요.

```csharp
Console.WriteLine("Hello, World!");
```

지금은 이 한 줄을 세 부분으로만 읽습니다.

- `Console`은 터미널과 대화할 때 사용하는 도구입니다.
- `WriteLine`은 글자를 출력하고 다음 줄로 이동하라는 동작입니다.
- `"Hello, World!"`는 화면에 보여 줄 글자입니다.

.NET 10 콘솔 템플릿은 이렇게 바로 실행할 코드를 적는 **top-level statements** 형태를 사용합니다. `Main`, 클래스, 네임스페이스는 나중에 필요해질 때 배웁니다.

## 8. 예측하기

아직 실행하지 말고 다음 질문에 먼저 답해 보세요.

> 이 프로그램을 실행하면 터미널에 정확히 어떤 한 줄이 나타날까요?

종이나 메모장에 예상 결과를 적은 다음 실제 결과와 비교합니다.

## 9. 실행하기

터미널이 저장소 루트인 `LetsStudyCS` 폴더를 가리키는지 확인한 뒤 다음 명령을 실행합니다.

```shell
dotnet run --project chapters/01-getting-started/examples/HelloWorld/HelloWorld.csproj
```

정확한 결과는 다음 한 줄입니다.

```text
Hello, World!
```

예상과 같았나요? 다르다면 코드를 다시 읽고 큰따옴표 안의 글자, 쉼표, 느낌표를 하나씩 비교해 보세요.

## 10. 막혔을 때

| 관찰한 문제 | 먼저 확인할 것 |
| --- | --- |
| `dotnet` 명령을 찾지 못함 | .NET **SDK** 설치 여부와 새 터미널을 열었는지 확인합니다. |
| 프로젝트 파일을 찾지 못함 | 터미널이 저장소 루트에 있는지 확인합니다. |
| SDK 버전이 맞지 않음 | `dotnet --version`이 `10.0`으로 시작하는지 확인합니다. |
| VS Code가 C# 프로젝트를 인식하지 못함 | C# Dev Kit 설치 여부를 확인하고 저장소 루트를 다시 엽니다. |
| 예상과 출력이 다름 | `Program.cs`의 큰따옴표 안 글자를 예상과 한 글자씩 비교합니다. |

오류 메시지는 실패의 낙인이 아니라 현재 무엇을 확인해야 하는지 알려 주는 관찰 결과입니다.

## 지금까지 확인할 것

- [ ] 프로그래밍으로 해결할 수 있는 일상 문제 하나를 말할 수 있습니다.
- [ ] C#은 언어이고 .NET은 만들고 실행하는 도구와 환경이라고 구분할 수 있습니다.
- [ ] 이 과정이 C#을 선택한 이유 하나를 말할 수 있습니다.
- [ ] `dotnet --version` 결과가 `10.0`으로 시작합니다.
- [ ] 실행 전에 Hello World의 출력을 예측했습니다.
- [ ] 저장소의 예제를 실행해 `Hello, World!`를 확인했습니다.

다음 단계에서는 프로그램의 동작을 테스트로 확인하고, 실패하는 테스트를 직접 통과시켜 봅니다.

## 공식 참고 자료

- [C# 둘러보기: Hello World](https://learn.microsoft.com/dotnet/csharp/tour-of-csharp/tutorials/hello-world)
- [C# top-level statements](https://learn.microsoft.com/dotnet/csharp/fundamentals/program-structure/top-level-statements)
- [.NET CLI 개요](https://learn.microsoft.com/dotnet/core/tools/dotnet)
- [Visual Studio Code에서 C# 시작하기](https://code.visualstudio.com/docs/csharp/get-started)
