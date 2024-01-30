﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SystemParty1.  ISO2002 ID# _klv_Mu5NEeCisYr99QEiWA_234780156.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the definition of a party within a system. 
/// A party shall denote any legal or organisational entity required in the system. 
/// This entity shall store the parties from the first three levels: the system operator, the central securities depositaries, the participants of the central securities depositaries, the national central banks and payment banks.
/// </summary>
public partial record SystemParty1
{
    #nullable enable
    
    /// <summary>
    /// Unique identification to unambiguously identify the party within the system.
    /// </summary>
    public required SystemPartyIdentification1 Identification { get; init; } 
    /// <summary>
    /// Information that locates and identifies a specific address.
    /// </summary>
    public PostalAddress10? Address { get; init; } 
    /// <summary>
    /// Specifies the opening date of the party.
    /// </summary>
    public required IsoISODate OpeningDate { get; init; } 
    /// <summary>
    /// Specifies the closing date of the party.
    /// </summary>
    public IsoISODate? ClosingDate { get; init; } 
    /// <summary>
    /// Specifies the type classification of the party.
    /// </summary>
    public required SystemPartyType1Code Type { get; init; } 
    /// <summary>
    /// Unique technical address to unambiguously identify a party for receiving messages from the executing system.
    /// </summary>
    public ITechnicalIdentification1Choice? TechnicalAddress { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional attributes defined by a central security depositary for a party.
    /// </summary>
    public MarketSpecificAttribute1? MarketSpecificAttribute { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public required PartyName1 Name { get; init; } 
    /// <summary>
    /// Defines the specific processing characteristics for a party to ensure configurability of specific requirements, as prescribed by national legal and regulatory requirements and practices.
    /// </summary>
    public SystemRestriction1? Restriction { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
