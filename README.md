# Semana de Tecnologia UniAnchieta 2025 — Desenvolvimento de aplicações com C#

## Slides

- [Slides da apresentação (PDF)](Slides/SemanaTecnologiaAnchieta2025_CSharp.pdf) — PDF com os slides usados na apresentação.

Este repositório contém dois exemplos usados no workshop sobre desenvolvimento de aplicações com C# durante a Semana de Tecnologia da UniAnchieta 2025. Os exemplos focam em comunicação em tempo real e reatividade, mostrando implementações em C# usando SSE e SignalR.

- BlazorServerSentEvents — Demonstração de reatividade usando Server-Sent Events (SSE) com um backend ASP.NET e um cliente Blazor WebAssembly hospedado.
- BlazorServerSignalR — Demonstração de reatividade usando SignalR com um backend ASP.NET e um cliente Blazor WebAssembly hospedado.

## Estrutura do repositório

- `Codigo/` — Ssolução C# desenvolvida na palstra
- `Slides/` — Slides utilizados na paletra em formato PDF
- `Fotos/` — Fotos da palestra

## Requisitos

- .NET SDK 10 (pré-visualização) — os projetos alvo são `net10.0` e usam pacotes preview conforme aparecem nos `.csproj`.
  - Baixe e instale a versão apropriada do SDK em https://dotnet.microsoft.com (procure pela série .NET 10 preview).
- Git e utilitários de linha de comando (opcional)

## Como executar (modo rápido)

Cada solução é um projeto C# que pode ser executado individualmente.

1. Abrir um terminal na raiz do repositório.

2. Rodar a solução:

```bash
cd Codigo
dotnet run
```

## Observações para desenvolvimento e debugging

- Ports/URLs: os exemplos usam as configurações padrão do `launchSettings.json` quando executados via `dotnet run`. Verifique `Properties/launchSettings.json` dentro de cada projeto se precisar de portas específicas.
- Pacotes preview: se preferir não usar previews, atualize `TargetFramework` e `PackageReference` nos `.csproj` para versões estáveis compatíveis.