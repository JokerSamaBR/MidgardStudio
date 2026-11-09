# Histórico — Midgard Studio WYO Digital Edition

## 1.2.0 — edição WYO Digital (2026-11-09)
- Marca própria WYO Digital com atribuição à versão original de Kyoshio.
- Configurações, logs e backups isolados em D:\GAME por padrão quando presente.
- Suporte a WYO_MIDGARD_HOME e launcher para cache .NET no disco D.
- Atualizador consulta versões lançadas nesta edição.
- CI Windows compila, roda testes e gera aplicativo portátil.
- Nenhuma alteração na base protegida WYO ou em dados de servidor real.

> Este changelog descreve o código da edição. Disponibilização de binário depende da conclusão verde do workflow.


### Interface — idiomas inglês e português brasileiro
- Adicionado menu de idioma na janela principal (English / Português (Brasil)).
- Inglês padrão e preferência persistida em `app-settings.json`.
- Textos estáticos do menu e comandos principais usam recursos WPF dinâmicos.
- Sem alterações nos dados editados ou na leitura de GRF.

- A janela principal inicia em modo normal, centralizada, a 1100 × 720, com maximização manual e redimensionamento habilitado.
