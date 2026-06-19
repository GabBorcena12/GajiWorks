# GajiWorks

GajiWorks is a responsive portfolio website for independent website and business solution services. It presents industry experience, service options, selected work, pricing guidance, a client-focused process, and a demonstration inquiry form.

## Features

- Premium dark theme with responsive desktop, tablet, and mobile layouts
- Main navigation and floating section shortcuts with active-section highlighting
- Selected Work cards with dedicated preview images
- Responsive project modal with screenshot galleries and video previews
- Image auto-advance and muted video autoplay behavior
- Starting price estimates and negotiable pricing guidance
- Validated demonstration inquiry form with a success state
- Floating email, call, and Messenger shortcuts
- Static GitHub Pages version in `docs/`

## Projects shown

- Transformer & Electrical Business Website
- Real Estate Property Showcase
- Digital E-Wallet Platform
- POS & Inventory Backoffice

Project content and media are maintained in:

- `GajiWorks/Data/PortfolioProjects.cs` for the Blazor website
- `docs/site.js` for the static GitHub Pages website

## Run locally

Requirements: [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

```powershell
dotnet restore GajiWorks.slnx
dotnet run --project GajiWorks/GajiWorks.csproj
```

Open the local address displayed in the terminal.

## Build

```powershell
dotnet build GajiWorks.slnx
```

## GitHub Pages

The plain HTML, CSS, and JavaScript version is available in `docs/`. Configure GitHub Pages to deploy from the `docs` folder on the selected branch.

## Notes

- Contact details and inquiry submission are currently demonstrations.
- Live project links can be updated in the portfolio data files.
- Source links remain optional.
