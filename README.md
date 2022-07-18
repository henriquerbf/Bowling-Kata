# Bowling-Kata

# Regras de boliche
-O jogo consiste em 10 rodadas. Em cada rodada o jogador tem duas jogadas para derrubar os pinos, no total são 10 pinos. A pontuação para a rodada é o número total de pinos derrubados, mais bônus por strikes e spares.

-Strike: quando todos os 10 pinos são derrubados na primeira jogada da rodada, neste caso não há segunda jogada e o jogador ganha um bônus igual ao valor de pontos das duas proximas jogadas.

-Spare: quando todos os 10 pinos são derrubados em duas jogadas, neste caso o jogador ganha um bônus igual ao valor da próxima jogada.

-Na décima rodada, caso o jogador faça spare terá direito a mais uma jogada, caso faça strike terá direito a mais duas jogadas, sendo um total de 3 jogadas na ultima rodada nestes casos.

# Bônus Example
Strike:
    # Play
    Frame 1, roll 1: 10 pins (strike)
    Frame 2, roll 1: 10 pins (strike)
    Frame 3, roll 1: 4 pins
    Frame 3, roll 2: 2 pins

    # Score
    Frame 1: 10 + (10 + 4) = 24
    Frame 2: 10 + (4 + 2) = 16
    Frame 3: 4 + 2 = 6
    TOTAL = 46

Spare:
    # Play
    Frame 1, roll 1: 7 pins
    Frame 1, roll 2: 3 pins (spare)
    Frame 2, roll 1: 4 pins
    Frame 2, roll 2: 2 pins

    # Score
    Frame 1: 7 + 3 + 4 (bonus) = 14
    Frame 2: 4 + 2 = 6
    TOTAL = 20

# Requisitos
-Escreva uma classe Game que tenha dois métodos

-void roll(int) é chamado cada vez que o jogador rola uma bola. O argumento é o número de pinos derrubados.

-int score() retorna a pontuação total para aquele jogo.