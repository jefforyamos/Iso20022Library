﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentTransaction23.  ISO2002 ID# _PyBzddp-Ed-ak6NoX_4Aeg_343027931.
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
/// Payment processes required to transfer cash from the debtor to the creditor.
/// </summary>
[IsoId("_PyBzddp-Ed-ak6NoX_4Aeg_343027931")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Payment Transaction")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentTransaction23
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Choice between types of payment instrument, ie, cheque, credit transfer, direct debit, investment account or payment card.
    /// </summary>
    [IsoId("_PyBzdtp-Ed-ak6NoX_4Aeg_343028647")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment Instrument")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentInstrument12Choice_? PaymentInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstrument12Choice_? PaymentInstrument { get; init; } 
    #else
    public PaymentInstrument12Choice_? PaymentInstrument { get; set; } 
    #endif
    
    
    #nullable disable
    
}
