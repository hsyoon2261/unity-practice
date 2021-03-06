## 게임설계

## 프리팹(설계도), Factory, 충돌 판정

### 게임 기획하기 .
1. 화면 중앙에 플레이어 표시
2. 오른쪽 위 hp게이지 표시
3. 플레이어가 화살에 맞으면 hp게이지가 줄어든다.

### 게임 리소스 나열하기
1. 화면에 놓일 오브젝트를 모두 나열한다.
   - 플레이어(고양이), 화살, 배경, 이동버튼, hp게이지
2. 오브젝트를 움직일 수 있는 컨트롤러 스크립트롤 정한다.
   - 움직이는 오브젝트 : 플레이어, 화살
   - 따라서 플레이어 컨트롤러, 화살 컨트롤러를 만들어야 한다.
3. 오브젝트를 자동으로 생성할 수 있도록 제너레이터 스크립트를 정한다.
   - 게임을 플레이할 때 생성될 오브젝트를 찾습니다. 이번 게임에서는 화살이 위에서 아래로 떨어지는 화살
   - 화살 생성을 담당할 팩토리가 필요. 이 공장을 가동시키기 위한 제너레이터 스크립트 필요
4. UI를 갱신할 수 있도록 감독 스크립트를 준비한다.
   1. HP가 갱신되므로(화면=UI) HP 게이지를 갱신할 수 있는 감독(매니저) 스크립트가 필요.
5. 스크립트를 만드는 흐름을 생각한다.
   1. 컨트롤러 스크립트
      - 플레이어가 좌우 화살표 버튼을 눌렀을 때, 화살표 버튼이 눌린 것을 감지하고 움직이는 스크립트
      - 화살 컨트롤러
   2. 제너레이터 스크립트
      - 1초에 한개 비율로 생성 제너레이터
   3. 매니저 스크립트
      - 충돌을 감지하고(충돌판정) hp를 감소시키는 스크립트 작성 => 프리팹 개념.

순서
1. 플레이어 이동
2. 화살 이동
3. 충돌 판정
4. 팩토리 작성
5. 매니저 작성


## 간단한 충돌 판정
원의 중심과 반지름을 사용하여 충돌판정이 가능하다.

## 공장의 구성
화살 오브젝트를 1초에 한 개 씩 만드는 공장을 만든다. 
프리팹 = 설계도
프리팹을 제너레이터 스크립트로 넘기면 설계도대로 제품(인스턴스)를 생산해 줍니다.

## 프리팹 (설계도)
- 설계도 프리팹이 있으면 몇 개라도 같은 오브젝트를 만들 수 있습니다.

## 팩토리( 공장)
- 이미 있는 오브젝트를 사용해 프리팹을 만든다.
- 제너레이터 스크립트를 만든다.
- 빈 오브젝트에 제너레이터 스크립트를 적용한다. 
- 제너레이터 스크립트에 프리팹을 전달한다. 

## UI 갱신 감독
1. 감독 스크립트 작성
2. 빈 오브젝트 만들기
3. 빈 오브젝트에 감독 스크립트 적용하기 . 

flow
1. 감독 스크립트를 만든다(ui가 변경되는..)
2. 화살 컨트롤러는 감독에게 HP 가 감소되었다고 알린다.
3. 감독은 HP 게이지를 UI를 갱신하는 로직을 구현한다.



