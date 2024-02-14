﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CounterpartyIdentification12.  ISO2002 ID# _DrQZ4cg4Eeu4ecZgAYuz5w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to counterparty identification.
/// </summary>
[IsoId("_DrQZ4cg4Eeu4ecZgAYuz5w")]
[DisplayName("Counterparty Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CounterpartyIdentification12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CounterpartyIdentification12 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CounterpartyIdentification12( PartyIdentification236Choice_ reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the counterparty in the transaction.
    /// </summary>
    [IsoId("_DtZH4cg4Eeu4ecZgAYuz5w")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification236Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification236Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification236Choice_ Identification { get; init; } 
    #else
    public PartyIdentification236Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the branch of the counterparty, when the transaction concludes a transaction through a branch office.
    /// </summary>
    [IsoId("_DtZH48g4Eeu4ecZgAYuz5w")]
    [DisplayName("Branch")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Brnch")]
    #endif
    [IsoXmlTag("Brnch")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Branch6Choice_? Branch { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Branch6Choice_? Branch { get; init; } 
    #else
    public Branch6Choice_? Branch { get; set; } 
    #endif
    
    /// <summary>
    /// Country where the registered office of the counterparty is located or country of residence in case that the counterparty is a natural person.
    /// </summary>
    [IsoId("_DtZH5cg4Eeu4ecZgAYuz5w")]
    [DisplayName("Country Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryCd")]
    #endif
    [IsoXmlTag("CtryCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? CountryCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CountryCode { get; init; } 
    #else
    public string? CountryCode { get; set; } 
    #endif
    
    
    #nullable disable
    
}
