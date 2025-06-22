# Genius
O brinquedo [Genius](https://www.estrela.com.br/jogo-genius-estrela-100543353_est_pai/p) é um jogo eletrônico de memória popular nos anos 80. Lançado no Brasil pela [Estrela](https://www.estrela.com.br/), é a versão brasileira do americano [Simon](https://products.hasbro.com/pt-br/product/simon-game-for-kids-ages-8-and-up:11B65A99-E662-4178-9C36-4E2B63B52093), da [Hasbro](https://products.hasbro.com/pt-br).

[![Genius - Estrela](/img/genius.png)](https://estrela.vteximg.com.br/arquivos/ids/163355-1000-1000/Jogo-Genius-Produto-Estrela.jpg?v=636661399595430000)

## Tutorial


O objetivo do jogo é repetir corretamente a sequência de sinais proposta pelo próprio jogo, cada vez mais longa. Há quatro cores (vermelho, verde, azul e amarelo), e cada um emite um som característico.

São quatro níveis de dificuldade, que indicam quantas cores deverão ser acertadas:

| Dificuldade | Tamanho da sequência |
| :---------: | :------------------: |
|      1      |       8 rodadas      |
|      2      |      14 rodadas      |
|      3      |      20 rodadas      |
|      4      |      31 rodadas      |

Depois que o usuário seleciona a dificuldade, aparecerá uma tela mostrando as regras e como dizer a sequência:
```
--- Regras ---

Uma sequência de cores irá aparecer, acerte a ordem e passe para a próxima rodada
Digite os números abaixo de acordo com a ordem mostrada sem espaço entre cada número

1 para Vermelho
2 para Verde
3 para Azul
4 para Amarelo

Exemplo: Vermelho Amarelo Verde =>  142

Pressione 'R' para repetir o áudio     
Pressione 'Enter' para começar
```

Ao pressionar a tecla 'Enter', será mostrado durante alguns segundos uma cor, qual o usuário deverá memorizar.

```
Rodada 1

Vermelho
```

Caso o usuário acerte a cor, ele passará para a próxima rodada, onde a cor anterior será mostrada juntamente de uma nova cor, e assim sucessivamente.

```
Rodada 1

Digite a sequência (sem espaços):
1
Vermelho
Correto! Prepare-se para a próxima rodada...
```

Caso o usuário erre, será mostrado a sequência correta que deveria ser digitada e o jogo finaliza.
```
Rodada 1

Digite a sequência (sem espaços):
2
Verde
Sequência incorreta! Fim de jogo.
A sequência correta era: 1
```

O jogo se estenderá até que o usuário vença todas as rodadas delimitadas pela dificuldade selecionada ou erre a sequência.

## _Download_

- [Genius](/dist/Genius.zip)

## Execução

Caso não seja utilizado o windows (Não recomendado, pois o programa utiliza recursos disponíveis apenas no windows), execute o programa utilizando o seguinte comando:
```
dotnet Genius.dll
```

## Realizadores

- [Davi de Castro Oliveira](https://github.com/Davii75)
- [Leonardo Sacramento dos Santos](https://github.com/LeonardoSacra04)

---

Fontes: [Manual](https://statics-submarino.b2w.io/manuais/111703711.pdf); [_Reverse Engineering an MB Electronic Simon Game_, da Waiting for Friday](<https://www.waitingforfriday.com/?p=586#:~:text=On%20the%20full%E2%80%90size%20version%20of%20Simon%20the%20lights%20are,B3%20(true%20pitch%20247.942%20Hz)>).
