# Bowling-Kata
 
Regras de boliche
-O jogo consiste em 10 partidas. Em cada partidas o jogador tem duas jogadas para derrubar 10 pinos. A pontuação para a partida é o número total de pinos derrubados, mais bônus por golpes e peças de reposição.

-Um spare é quando o jogador derruba todos os 10 pinos em duas jogadas. O bônus para esse quadro é o número de pinos derrubados pelo próximo lançamento.

-Uma greve é ​​quando o jogador derruba todos os 10 pinos em sua primeira jogada. O quadro é então completado com um único rolo. O bônus para esse quadro é o valor dos próximos dois lançamentos.

-No décimo frame, um jogador que rola um spare ou strike pode rolar as bolas extras para completar o frame. No entanto, não mais do que três bolas podem ser roladas no décimo quadro.

Requisitos
-Escreva uma classe Game que tenha dois métodos

-void roll(int) é chamado cada vez que o jogador rola uma bola. O argumento é o número de pinos derrubados.
-int score() retorna a pontuação total para aquele jogo.