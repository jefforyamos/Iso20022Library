﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementFailsSecuritiesRange1.  ISO2002 ID# _BnlYg40bEemUAO64Q252gQ.
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
/// Specifies the highest volume and value of settlement fails with a ranking by financial instrument.
/// </summary>
[IsoId("_BnlYg40bEemUAO64Q252gQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Settlement Fails Securities Range")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementFailsSecuritiesRange1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Securities with the highest volume of settlement fails.
    /// </summary>
    [IsoId("_BnlYhY0bEemUAO64Q252gQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Highest In Volume")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    public SettlementFailsSecurities1? HighestInVolume { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _BnlYhY0bEemUAO64Q252gQ
    
    /// <summary>
    /// Securities with the highest value of settlement fails.
    /// </summary>
    [IsoId("_BnlYhI0bEemUAO64Q252gQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Highest In Value")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    public SettlementFailsSecurities1? HighestInValue { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _BnlYhI0bEemUAO64Q252gQ
    
    
    #nullable disable
    
}
