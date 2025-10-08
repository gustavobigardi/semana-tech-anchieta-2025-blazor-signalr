# Semana de Tecnologia UniAnchieta 2025 — Blazor reativo (SSE e SignalR)

Este repositório contém dois exemplos usados no workshop sobre reatividade no Blazor durante a Semana de Tecnologia da UniAnchieta 2025:

- BlazorServerSentEvents — Demonstração de reatividade usando Server-Sent Events (SSE) com um backend ASP.NET e um cliente Blazor WebAssembly hospedado.
- BlazorServerSignalR — Demonstração de reatividade usando SignalR com um backend ASP.NET e um cliente Blazor WebAssembly hospedado.

## Estrutura do repositório

- `BlazorServerSentEvents/` — solução SSE
  - `BlazorServerSentEvents/` — app servidor (host) que expõe endpoints SSE
  - `BlazorServerSentEvents.Client/` — cliente Blazor WebAssembly integrado

- `BlazorServerSignalR/` — solução SignalR
  - `BlazorServerSignalR/` — app servidor com `Hub` e endpoints necessários
  - `BlazorServerSignalR.Client/` — cliente Blazor WebAssembly integrado

## Requisitos

- .NET SDK 10 (pré-visualização) — os projetos alvo são `net10.0` e usam pacotes preview conforme aparecem nos `.csproj`.
  - Baixe e instale a versão apropriada do SDK em https://dotnet.microsoft.com (procure pela série .NET 10 preview).
- Um navegador moderno (Chrome/Edge/Firefox/Safari)
- Git e utilitários de linha de comando (opcional)

Observação: os projetos referenciam pacotes preview (ex.: `Microsoft.AspNetCore.Components.WebAssembly` v10.0.0-preview...); se preferir usar .NET 8/7 você precisará ajustar os arquivos `.csproj` e os pacotes.

## Como executar (modo rápido)

Cada solução é um projeto ASP.NET que hospeda um cliente Blazor WebAssembly. As instruções abaixo assumem que você tem o .NET SDK correto instalado e está no diretório raiz do repositório.

1. Abrir um terminal na raiz do repositório.

2. Rodar a solução SSE:

```bash
cd BlazorServerSentEvents/BlazorServerSentEvents
dotnet run --project BlazorServerSentEvents.csproj
```

- Após o servidor subir, abra o navegador em `https://localhost:5001` (ou a URL mostrada no terminal).
- A página `Pages/Chat.razor` do cliente demonstra recebimento de mensagens por SSE.

3. Rodar a solução SignalR (em outra janela de terminal):

```bash
cd BlazorServerSignalR/BlazorServerSignalR
dotnet run --project BlazorServerSignalR.csproj
```

- Abra `https://localhost:5001` (ou a URL indicada) para acessar o cliente que usa SignalR (`Pages/Chat.razor`).

## O que cada exemplo demonstra

- BlazorServerSentEvents
  - Backend envia eventos no formato SSE para os clientes conectados.
  - O cliente Blazor WebAssembly abre uma conexão e atualiza a UI reativamente quando recebe eventos.
  - Arquivos relevantes: `MessageService/MessageService.cs`, `Controllers/MessageController.cs`, `BlazorServerSentEvents.Client/Pages/Chat.razor`.

- BlazorServerSignalR
  - Backend usa um `Hub` (arquivo `ChatHub.cs`) para enviar mensagens em tempo real via SignalR.
  - Cliente usa `Microsoft.AspNetCore.SignalR.Client` para conectar e reagir a mensagens.
  - Arquivos relevantes: `ChatHub.cs`, `BlazorServerSignalR.Client/Pages/Chat.razor`.

## Observações para desenvolvimento e debugging

- Ports/URLs: os exemplos usam as configurações padrão do `launchSettings.json` quando executados via `dotnet run`. Verifique `Properties/launchSettings.json` dentro de cada projeto se precisar de portas específicas.
- Certificados de desenvolvimento: pode ser necessário confiar no certificado de desenvolvedor do ASP.NET se estiver acessando via HTTPS localmente; use `dotnet dev-certs https --trust` quando solicitado.
- Pacotes preview: se preferir não usar previews, atualize `TargetFramework` e `PackageReference` nos `.csproj` para versões estáveis compatíveis.

## Notas do workshop

- Objetivo: mostrar padrões de reatividade no Blazor usando duas abordagens (SSE e web sockets/SignalR). Cada abordagem tem trade-offs:
  - SSE: simples, unidirecional (server → client), bom para streaming de eventos.
  - SignalR: bidirecional, abstrai transporte (WebSockets/Long Polling), flexível para chat e interatividade.

- Exercícios sugeridos:
  - Modificar o servidor SSE para filtrar eventos por tópico/usuário.
    - Realizar o mesmo para a versão SignalR.
  - Adicionar reconexão automática e backoff no cliente SSE.
  - Implementar grupos em SignalR para salas de chat privadas.

