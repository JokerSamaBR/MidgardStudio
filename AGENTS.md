# Codex — Midgard Studio WYO Digital Edition

## Regras essenciais
- Trabalhar somente neste repositório, preservando a licença MIT + Commons Clause, avisos de direitos autorais de Kyoshio e créditos de bibliotecas de terceiros.
- Não alterar `JokerSamaBR/rathena-wyo-clean` nem mexer em servidor WYO de produção.
- Local de desenvolvimento previsto: `D:\GAME\MidgardStudio_WYO_Digital`.
- Manter o aplicativo WPF C#/.NET; não reescrever em outra stack sem necessidade.
- Código da versão original é referência. Não migrar, mover ou sobrescrever perfis de usuário de outras instalações.
- Ao mexer em serialização/import, testar byte-preservation e backups. GRF deve continuar somente leitura.
- Bugs críticos de escrita devem virar testes de regressão. Executar `dotnet test` e build no Windows antes de liberar versão.
- Não inventar testes executados. Se a CI falhar, corrigir antes de anunciar binários prontos.
- Ao mudar o app, atualizar README, CHANGELOG e docs/WYO_EDITION.md.
- Usar soluções gratuitas; evitar varreduras globais e orquestrações desnecessárias.
- Não distribuir assets de jogos de terceiros junto com a aplicação.
