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

## 11. 테스트는 무엇인가요?

**테스트**는 프로그램이 약속한 결과를 만드는지 코드로 확인하는 작은 점검입니다. 사람이 매번 화면을 읽어 판단하는 대신, 실행할 때마다 같은 기준을 자동으로 확인할 수 있습니다.

이 저장소는 C# 테스트 프레임워크로 **xUnit**을 사용합니다. 첫 테스트는 이미 준비되어 있으므로 새로운 문법을 외울 필요가 없습니다. 이번에는 테스트를 읽고, 실패 이유를 관찰하고, 인사말을 완성하는 데 집중합니다.

[첫 테스트](tests/HelloWorld.Practice.Tests/GreetingTests.cs)는 다음과 같습니다.

```csharp
[Fact]
public void CreateMessage_returns_hello_world()
{
    Assert.Equal("Hello, World!", Greeting.CreateMessage());
}
```

지금은 두 부분만 확인합니다.

- `[Fact]`는 xUnit에게 “이 동작을 테스트로 실행해 주세요”라고 알려 줍니다.
- `Assert.Equal(expected, actual)`은 기대한 값과 실제 값을 비교합니다.

이 테스트에서 expected는 `"Hello, World!"`이고 actual은 앱이 만든 인사말입니다.

## 12. 완성하기: 먼저 실패 확인

저장소 루트에서 다음 명령을 실행합니다.

```shell
dotnet test chapters/01-getting-started/tests/HelloWorld.Practice.Tests/HelloWorld.Practice.Tests.csproj
```

처음에는 **실패하는 것이 정상**입니다. 설정 오류가 아니라 다음 차이가 보여야 합니다.

```text
Expected: "Hello, World!"
Actual:   ""
```

테스트는 `Hello, World!`를 기대하지만, 연습 코드가 아직 빈 글자를 돌려주기 때문입니다.

[연습용 `Greeting.cs`](practice/HelloWorld/Greeting.cs)를 열어 다음 줄을 찾습니다.

```csharp
return "";
```

큰따옴표 안을 완성합니다.

```csharp
return "Hello, World!";
```

테스트를 다시 실행합니다.

```shell
dotnet test chapters/01-getting-started/tests/HelloWorld.Practice.Tests/HelloWorld.Practice.Tests.csproj
```

이번에는 테스트 한 개가 통과해야 합니다. 앱도 실행해 같은 결과를 확인합니다.

```shell
dotnet run --project chapters/01-getting-started/practice/HelloWorld/HelloWorld.csproj
```

```text
Hello, World!
```

## 13. 직접 만들기: 나만의 인사말

이번에는 red-green 순서를 스스로 한 번 더 만듭니다. 두 파일을 동시에 바꾸지 말고 다음 순서를 지키세요.

1. `GreetingTests.cs`에서 기대값만 `"Hello, C#!"`처럼 자신의 인사말로 바꿉니다.
2. 테스트를 실행해 실제 값과 달라서 다시 실패하는지 확인합니다. 이것이 red입니다.
3. `Greeting.cs`의 인사말을 같은 문장으로 바꿉니다.
4. 테스트를 다시 실행해 통과하는지 확인합니다. 이것이 green입니다.
5. 연습 앱을 실행해 자신의 인사말이 출력되는지 확인합니다.

테스트를 먼저 바꾸고 실패를 확인해야 테스트가 실제로 새 약속을 검사하는지 알 수 있습니다.

## 14. 테스트에서 막혔을 때

| 관찰한 문제 | 먼저 확인할 것 |
| --- | --- |
| 테스트가 발견되지 않음 | 명령에 `HelloWorld.Practice.Tests.csproj` 경로를 사용했는지 확인합니다. |
| 기대값 불일치 한 개가 보임 | 처음 실행이라면 정상입니다. expected와 actual을 비교합니다. |
| 빌드 오류가 보임 | 큰따옴표와 세미콜론을 지우지 않았는지 확인합니다. |
| 고친 뒤에도 실패함 | 테스트의 기대값과 `Greeting.cs`의 인사말이 한 글자까지 같은지 확인합니다. |

먼저 직접 시도한 뒤에도 막힌다면 [정답의 `Greeting.cs`](solution/HelloWorld/Greeting.cs)와 [정답 테스트](tests/HelloWorld.Solution.Tests/GreetingTests.cs)를 같은 역할의 연습 파일과 비교하세요. 정답 프로젝트는 다음 명령으로 따로 확인할 수 있습니다.

```shell
dotnet test chapters/01-getting-started/tests/HelloWorld.Solution.Tests/HelloWorld.Solution.Tests.csproj
```

`class`, `public`, `static`, 메서드의 자세한 뜻은 지금 외우지 않아도 됩니다. 테스트할 수 있도록 미리 준비된 “인사말 만드는 기능”이라고만 이해하고, 표시된 인사말 한 줄에 집중하세요.

## 1장 완료 체크

- [ ] 프로그래밍으로 해결할 수 있는 일상 문제 하나를 설명했습니다.
- [ ] C#과 .NET의 차이와 이 과정이 C#을 선택한 이유 하나를 설명했습니다.
- [ ] `dotnet --version`에서 .NET 10 SDK를 확인했습니다.
- [ ] 실행 전에 Hello World 출력을 예측하고 실제 결과와 비교했습니다.
- [ ] 제공된 `[Fact]`와 `Assert.Equal` 테스트를 읽었습니다.
- [ ] 의도된 실패를 확인한 뒤 인사말을 완성해 테스트를 통과시켰습니다.
- [ ] 나만의 인사말로 red-green을 한 번 더 만들었습니다.

이제 코드를 실행하고 테스트로 확인하는 방법을 알았습니다. 2장부터는 값과 변수를 배우며 낙하 블록 게임의 첫 상태를 표현합니다.

## 공식 참고 자료

- [C# 둘러보기: Hello World](https://learn.microsoft.com/dotnet/csharp/tour-of-csharp/tutorials/hello-world)
- [C# top-level statements](https://learn.microsoft.com/dotnet/csharp/fundamentals/program-structure/top-level-statements)
- [.NET CLI 개요](https://learn.microsoft.com/dotnet/core/tools/dotnet)
- [Visual Studio Code에서 C# 시작하기](https://code.visualstudio.com/docs/csharp/get-started)
- [xUnit으로 C# 단위 테스트하기](https://learn.microsoft.com/dotnet/core/testing/unit-testing-csharp-with-xunit)
