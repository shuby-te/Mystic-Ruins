# :pushpin: Mystic Ruins
>게임 플레이 데모   
>https://drive.google.com/file/d/1EE2pPsvo2xygQ4Q2I5kPO9wL5JgjHtGb/view?usp=drive_link

</br>

## 1. 프로젝트 정보
### **1) 제작 기간**
>2023.9.1 ~ 2023.12.28

### **2) 참여 인원**
>프로그래머 : 정태수, 손성혁   
>그래픽 디자이너 : 박재형, 안태성

</br>

## 2. 역할 분담
**정태수**
>플레이어 캐릭터 물리 기반 움직임 구현   
>JSON 기반 세이브 시스템 구현   
>원소 스킬 구현   
>오브젝트 상호 작용 구현   
>게임 내 모든 퍼즐 및 상호작용 기능 구현   
>아이템 획득 및 사용 기능 구현   
>튜토리얼 레벨 구현   
>힌트 기능 구현   
>메인 레벨 UI 구현   

</br>

## 3. 사용 기술
#### `프로그래머`
- Unity
- C#

#### `그래픽 디자이너`
- 3ds Max
- Substance 3D Painter
- Adobe Photoshop

</br>

## 4. 핵심 기능
- 아이템 매니저를 통해 획득 가능한 아이템 정보를 저장하고 관리합니다.
- JSON 기반의 세이브 시스템을 통해 플레이어 위치, 소지 아이템, 퍼즐 진행도, 기타 오브젝트 위치를 저장하고 불러올 수 있습니다.
- 각 퍼즐들은 설계된 구조에 맞게 작동합니다.

</br>

## 5. 핵심 트러블 슈팅
### 5.1. 플레이어 캐릭터 애니메이션 FSM 구조 문제
- 유니티에서 제공하는 '메카님'은 한 오브젝트에 적용한 복수의 애니메이션을 연결시키고 전이되도록 해주는 FSM(유한 상태 기계)입니다.
저는 플레이어 캐릭터가 이동 시의 달리는 애니메이션을 8개의 방향마다 다른 애니메이션을 적용하여 달리는 애니메이션이 부드럽게 적용되도록 구현했습니다.
- 하지만 아래와 같은 구조는 하나의 상태에서 다른 상태로 전이되기 위해 여러 상태를 거쳐야하는 경우가 생겨 전이 속도가 느려지는 문제가 발생하였다.

<details>
<summary><b>기존의 메카님</b></summary>
<div markdown="1">
  
![](https://github.com/shuby-te/Mystic-Ruins/assets/101082590/2e27b860-0649-4d1d-9cac-8f7e6a7f9bca)

</div>
</details>

- 아래의 **수정한 메카님**과 같이 달리는 애니메이션을 4방향으로 줄이고 애니메이션 전환 타이밍과 시간을 0으로 설정하여 좀 더 부드러운 움직임이 가능하도록 수정하였다.

<details>
<summary><b>수정한 메카님</b></summary>
<div markdown="1">
  
![image](https://github.com/shuby-te/Mystic-Ruins/assets/101082590/2e325fd9-0369-45a1-b129-8e7ff9e543c3)

</div>
</details>
