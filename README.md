# Beneficial Strategies ISO20022 Library

This project defines the data structures to act as containers for ISO20022 messages.

## Let's talk why

[ISO20022](https://iso20022.org) is fast becoming the defacto language for sending financial information between financial partners. There is limited analytical knowledge of the domain.
It's not just for banks any more. Increasingly, this will be used in the corporate scenario for payables, receivables, payroll, etc. 

## Let's talk scope

Originally, the vision for this project included serialization, validation and several other objectives. 
It was deep **and** wide.  It was deep given that it covered over 2600 messages, the full message set of ISO20022 defined messages.
It was wide in that it sought to solve several business problems surrounding those messages.
After much thrashing about, that scope has intentionally narrowed. 
The depth remains the same. It [includes all currently defined messages](doc/Scope-Statement.md) in the ISO specification.
However, the width has been curtailed to provide the technological answer to one question:

> In what format should ISO20022 data exist in memory in an enterprise .NET application?

It is the goal of this project to be *the most standard* answer to that question. A few things are in-scope and in-focus:

- Custom attribute metadata to assist in dependent tools.
- Extremely rich with code comments.
- Ability to quickly add newly declared types when the ISO specification is updated.
- Use language features to ensure adherence to specified requirements. Make the compiler demand required data elements for example.
- Leverage language features to enable good code practices
    - Immutable [records](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/records) 
    - Value equivalency
- Remain as close as possible to the specification on naming. Make only the necessary adjustments in naming to make the code compile.

## What's notably missing?

There are many things, necessary things that are intentionally missing from this project. 
They are intended to be follow-on projects that extend what we are doing here.
They most certainly include the following:

- Validation
- XML Schema Validation
- Serialization
- Business rules

## Why is this approach better?

The most common quick-and-dirty approach to serializing these messages is to use the only marginally supported [Microsoft XSD tool](https://learn.microsoft.com/en-us/dotnet/standard/serialization/xml-schema-definition-tool-xsd-exe) to generate a data proxy. If you only have a few messages to support, that might be a worthy approach. Here are the reasons you might not want to use that approach:

- Most of the classes generated in the proxy are repeats that are also used in other messages.
    - You get zero reuse across messages.
    - If you have a certain type of Name and Address object in one object, you cannot assign that value to another object in another message because they are two different data types.
    - If you end up using many ISO messages, you get code glut over time since there are multiple copies of many of the objects.
- There is zero documentation burned into the proxy contents.
- If there's something wrong about the way it generates, there's little you can do to fix it.
- It is difficult to create frameworks around these proxy objects because there are no interfaces in common and no shared data objects.

## A word about the support cycle

At very least, [Beneficial Strategies](https://www.beneficialstrategies.com/iso20022/) has intentions of creating more tools with this library as its bedrock. We will be building those tools at any moment against a [Nuget-versioned](https://www.nuget.org) copy of this library. The release cycle on those tools will follow new releases of this library. Since the library doesn't include any procedural logic, there's none of that to break.  The updates/fixes should fall into these categories:

- ISO2002 standard update - feature branch
- Improvements in metadata
- Correction of cardinality or data relationships - defect branch
    - You've only got a single X for Y and it should be a collection
    - In X, Y should be nullable and it's not
- Tweaking of compile directives across versions

For anyone having a dependency on this library, the changes should be easy to maintain.  When you update the reference to the new version, the compiler is going to let you know very quickly if it sees any breaking changes.

## Trying out the library 

It is presumed you already have the [latest .NET SDK](https://dotnet.microsoft.com/en-us/download/visual-studio-sdks) installed. You should also have [Visual Studio Code](https://code.visualstudio.com/download) or some other text editor.  It is preferable if you have the [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit) also installed. 

#### Attention: This documentation is preliminary. The library is not yet published to NuGet.

```DOS
mkdir test
cd test
dotnet new console
dotnet add package com.BeneficialStrategies.Iso20022 --prerelease
```

You should then open your Program.cs file, and paste the following code into your code:

```C#
var myMessage = new CustomerCreditTransferInitiationV11
{
    GroupHeader = new()
    {
        MessageIdentification = "ABC/120928/CCT001",
        CreationDateTime = new DateTime(2012, 09, 28, 14, 7, 0),
        NumberOfTransactions = "3",
        ControlSum = 11500000,
        InitiatingParty = new()
        {
            Name = "ABC Corporation",
            PostalAddress = new()
            {
                StreetName = "Times Square",
                BuildingNumber = "7",
                PostCode = "NY 10036",
                TownName = "New York",
                Country = "US"
            },
        },
    },
    PaymentInformation = new()
    {
        PaymentInformationIdentification = "ABC/086",
        PaymentMethod = Codesets.PaymentMethod3Code.CreditTransfer,
        BatchBooking = "FALSE",
        RequestedExecutionDate = new Choices.DateAndDateTime2Choice.Date { Value = new DateOnly(2012, 09, 29) },
        Debtor = new()
        {
            Name = "ABC Corporation",
            PostalAddress = new()
            {
                StreetName = "Times Square",
                BuildingNumber = "7",
                PostCode = "NY 10036",
                TownName = "New York",
                Country = "US"
            },
        },
        DebtorAccount = new()
        {
            Identification = new Choices.AccountIdentification4Choice.Other
            {
                Identification = "00125574999",
            },
        },
        DebtorAgent = new()
        {
            FinancialInstitutionIdentification = new Components.FinancialInstitutionIdentification18
            {
                BICFI = "BBBBUS33",
            },
        },
        CreditTransferTransactionInformation =
        
            new()
            {
                PaymentIdentification = new Components.PaymentIdentification6
                {
                    InstructionIdentification = "ABC/120928/CCT001/1",
                    EndToEndIdentification = "ABC/4562/2012-09-08",
                },
                Amount = new Choices.AmountType4Choice.InstructedAmount { Value = 10_000_000m },
                ChargeBearer = Codesets.ChargeBearerType1Code.Shared,
                CreditorAgent = new()
                {
                    FinancialInstitutionIdentification = new()
                    {
                        BICFI = "AAAAGB2L",
                    },
                },
                Creditor = new()
                {
                    Name = "DEF Electronics",
                    PostalAddress = new()
                    {
                        AddressLine = [
                            "Corn Exchange 5th Floor",
                            "Mark Lane 55",
                            "EC#R7NE London",
                            "GB"
                            ]
                    },
                },
                CreditorAccount = new()
                {
                    Identification = new Choices.AccountIdentification4Choice.Other
                    {
                        Identification = "23683707994215",
                    },
                },
                Purpose = new Choices.Purpose2Choice.Code
                {
                    Value = Codesets.ExternalPurpose1Code.InstantPaymentsForDonations, // Todo: What should this be??
                },
                RemittanceInformation = new()
                {
                    Structured = 
                        new()
                        {
                            ReferredDocumentInformation =
                            
                                new()
                                {
                                    Type = new()
                                    {
                                        CodeOrProprietary = new Choices.ReferredDocumentType3Choice.Code
                                        {
                                            Value = Codesets.DocumentType6Code.CommercialInvoice,
                                        },
                                    },
                                    Number = "4562",
                                    RelatedDate = new DateOnly(2012,09,08),
                                }
                            ,
                        }
                    ,
                },
            },
            // Last transaction
        
    },
};
Console.WriteLine(myMessage.ToString());
```

Things to notice:

- The compiler helps you do the right thing. Since it's all strongly-typed, you won't have a problem putting one System.Object instance where a different System.Object is expected.
- Notice intellisense gives you context about the transaction.
- Notice that date/time values are strongly typed. No worries about whether some string value is "yyyyMMdd" or "MMddYYY" or whatever.  
- Notice if you get bored with this message, there's over 2600 that are just as good, maybe better!

