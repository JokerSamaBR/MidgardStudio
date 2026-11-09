# Edição WYO Digital — mudança incremental segura

**Base:** Midgard Studio / Kyoshio. A licença em \`LICENSE\` permanece inalterada: MIT + Commons Clause (venda do software restringida).

## Alterações 1.2.0 WYO

- Produto e janela com identificação **WYO Digital Edition**, com créditos ao autor original.
- Nova identidade visual em tons de verde/azul, com ícone e logotipo próprios.
- Verificação de novas versões direcionada para as Releases deste repositório, sem apontar para a distribuição original.
- Dados locais separados em \`D:\GAME\MidgardStudio_WYO_Digital\` quando \`D:\GAME\` existe.
- Suporte a \`WYO_MIDGARD_HOME\` para localização explícita, sem mover arquivos da versão original.
- Arquivo \`Iniciar_WYO_Studio.bat\` para iniciar e colocar também o cache do .NET em D.
- Pipeline do GitHub Actions para compilar/testar e empacotar o aplicativo Windows x64 portátil.
- Testes para os caminhos de dados e backups isolados.

## Preservação de comportamento

- O editor continua WPF/.NET, e não foi reescrito para outra linguagem.
- As regras de leitura da base e gravação na camada import continuam válidas.
- A visualização GRF permanece leitura apenas, não editor de GRF.
- Perfis existentes da versão original **não** são migrados ou modificados.
- Não se pressupõe compatibilidade total com quaisquer modificações privadas do WYO sem testes com uma cópia isolada.

## Antes da distribuição

1. GitHub Actions deve terminar em **Success** para build, testes e pacote.
2. O aplicativo deve ser aberto em Windows 10/11 x64 para teste de inicialização (um runner CI não prova usabilidade visual).
3. Verificar avisos de licença do Midgard Studio e de dependências de terceiros.
4. Não anunciar como produto pago nem remover créditos.
5. Nunca editar \`JokerSamaBR/rathena-wyo-clean\`.

## Próximos incrementos possíveis

- Localização PT-BR completa de menus, com tradução revisada por tela.
- Otimizações de fluxo de itens customizados e banco de dados.
- Verificação contra datasets sintéticos, especialmente YML/LUA customizados.
- Testes visuais em Windows real e melhorias de performance de GRF grandes.

Nenhuma dessas melhorias futuras é marcada como pronta nesta versão.
