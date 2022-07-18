# Bowling-Kata
 
Regras de boliche
-O jogo consiste em 10 partidas. Em cada partidas o jogador tem duas jogadas para derrubar 10 pinos. A pontuação para a partida é o número total de pinos derrubados, mais bônus por golpes e peças de reposição.

-Um spare é quando o jogador derruba todos os 10 pinos em duas jogadas. O **bônus** para esse quadro é o número de pinos derrubados pelo próximo lançamento.

-Um strike é ​​quando o jogador derruba todos os 10 pinos em sua primeira jogada. O frame é então completado com uma única jogada. O bônus para esse frame é o valor dos próximos dois lançamentos.

-No décimo frame, um jogador que rola um spare ou strike pode rolar as bolas extras para completar o frame. No entanto, não mais do que três bolas podem ser roladas no décimo quadro.


**BONUS**
A fórmula da CONTAGEM DE PONTOS NO BOLICHE tem as seguintes variáveis:

Os pontos são a soma dos pinos derrubados.
Exceto quando fizer Strike (derrubar 10 pinos na 1.ª bola)
ou Spare (derrubar 10 pinos nas duas bolas jogadas)
Se fizer Strike ganha bônus nas 2 bolas jogadas a seguir,
Se fizer Spare ganha bônus na próxima bola jogada.
O bônus é igual ao número de pinos derrubados.
O total de 1 partida pode variar de zero a 300 pontos.



Requisitos
-Escreva uma classe Game que tenha dois métodos

-void roll(int) é chamado cada vez que o jogador rola uma bola. O argumento é o número de pinos derrubados.
-int score() retorna a pontuação total para aquele jogo.