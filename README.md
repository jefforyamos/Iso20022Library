# Beneficial Strategies ISO20022 Library

This is a work-in-progress attempt to provide a very robust, very flexible and extensible library for sending and receiving ISO20022 messages.

Objectives:

- Must be all-inclusive.  Must cover the entirety of the ISO20002 specification.
- Must reflect programatically most if not all of the business structures in the specfication.
- Must enable dependency injection without mandating a specific DI tool.
- Must be self-documented.  Codebase should be rich with comments that help as much as possible with analysis.
- Leverage forward coding to avoid mistakes.
- Use partial classes/interfaces where appropriate to provide internal extensibility like hard-coded logic that *plays-nice* with the generated code.
- Use modern versions of .NET tools.  Compatibility with ancient versions is a non-goal.
- Leverage the use of records where appropriate.
- Where reflection is used, it must be performant.
- Liberal use of interfaces, even in the data model. A helper method can sometimes be created for a specific interface and thus be useful for an entire family of similar messages.
- Rely as much as possible on serialization native to .NET.
- Where business rules are specified, facilitate adherence in the codebase as much as possible.

Done so far:

- Basic parsing of the ISO repository.
- Basic tools for pre-processing the repository data preparing it for efficient use by a variety of types of code generators.
- Generation of Enums where lookup values are finite and defined in the specification.
- Generation of interfaces for lookup of all possible values for a given coded value.
- Generation of implementaton code that gathers information for the dropdown rows.

Next to do:

- Unit tests.  Most likely using XUnit.
- Generate records for the supported data types.
- Determine strategy on how to deal with simple types. (string, datetime, etc)
- Determine whether different DLLs should be created for the different families of messages (pain,conv, etc)
- Data validation framework.
- Implement data validation rules for those declared in the specification data.
- Implement declarations for workflows as defined in the specification data.
- Strategy on PII masking.  (hiding of personally-identifiable-information for security reasons)

After I complete the code-generation aspects, I may be looking for participation on grinding out the more mundane business rules.