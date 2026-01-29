# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

This is the **Iso20022Library** - a generated .NET library containing 2,665 ISO20022 financial message types as immutable C# records. The code is auto-generated from the ISO20022 specification by the parent project (Iso20022MasterControl).

**NuGet Package**: `BeneficialStrategies.Iso20022`

## Build Commands

```bash
# Build the library
cd src && dotnet build iso20022.sln

# Build for all target frameworks
cd src && dotnet build BeneficialStrategies.Iso20022.Common -c Release
```

**Target Frameworks**: NET8, NET7, NET6

## Architecture

### This is Generated Code

All `.g.cs` files are auto-generated. Do not edit them directly. To modify generated code, changes must be made in the parent generator project (Iso20022MasterControl).

### Directory Structure

```
src/BeneficialStrategies.Iso20022.Common/
├── Framework/           # Hand-written base interfaces and helpers
├── Components/          # Generated message components (12,653 types)
├── Choices/             # Generated polymorphic choice types
├── Codesets/            # Generated enums (3,774 types)
├── Amounts/             # Generated amount types
├── ExternalSchema/      # External schema references
├── UserDefined/         # User-defined content placeholders
├── Metadata/            # Attribute definitions
└── [business areas]/    # 36 business area folders (pain, pacs, camt, seev, etc.)
```

### Business Area Abbreviations

| Abbr | Description |
|------|-------------|
| `pain` | Payment Initiation (customer-to-bank) |
| `pacs` | Payments Clearing and Settlement |
| `camt` | Cash Management (statements, reports) |
| `seev` | Securities Events (corporate actions) |
| `sese` | Securities Settlement |
| `semt` | Securities Management |

### Generated Code Patterns

**Messages** (`[area]/MessageName.g.cs`):
- Implement `IOuterRecord` interface
- Include `IsoIdentifier` constant (e.g., `"pain.001.001.11"`)
- Rich XML documentation from ISO spec

**Choice Types** (`Choices/[ChoiceName]/`):
- Abstract base record with `[JsonDerivedType]` attributes
- Concrete variant records for each option

**Codesets** (`Codesets/[Name]Code.g.cs`):
- Enums with `[EnumMember]` and `[IsoId]` attributes
- Versioned codes (e.g., `PaymentMethod3Code`)

### Key Interfaces (Framework/)

- `IOuterRecord` - All top-level messages
- `IOuterDocument` - XML document wrapper
- `IIsoXmlSerializable` - Serialization contract
