# MEMO

## 2 APPLICATION
- WPF 프로젝트 생성 시 기본적으로 함께 생성되는 파일들을 제거하고 직접 Entry Point를 구성하였다.
- Prism 라이브러리의 PrismApplication을 상속받는 App 클래스와 추상 메서드인 CreateShell을 구현하였다.
- Entry Point를 지정하기 위해 Starter.cs 파일을 생성하고 Main 메서드를 구현하였다.

## 3 DarkWindow
- 사용자 지정 컨트롤 (CustomControl)을 통한 UI 구현과 기본 구성에 대해 실습하였다.
- 사용자 지정 컨트롤에서 Themes/Generic.xaml의 역할에 대해 알아보았다.
- 각각 UI Unit에 대한 리소스 사전이 Themes/Generic.xaml 내에서 ResourceDictionary.MergedDictionaries를 통해 병합되는 방식을 알아보았다.
- 최종적으로 프로젝트 참조를 통해 WpfExplorer에 연결하였고, App.xaml에서 DarkWindow를 사용하였다.

## 4 EXPLORER WINDOW
- DarkWindow에서 ContentPresenter 부분은 ExpolorerWindow의 Content 속성이 채우게 되는 부분임

## 5 MULTIPLE ITEMSCONTROL
- ItemsControl은 컬렉션을 통해 반복되는 데이터를 표시하는 컨트롤이다.
- TreeView가 파생된 ItemsControl은 ItemsPresenter이 반드시 필요함 (ContentControl에서 기본적으로 Control이 존재하고 ContentPresenter가 확장 개념이였던 것에 반해)
- Generic.xaml을 통해 관리되는 CustomControl은 로드 시점에 영향을 받지 않는 장점이 있음
- 