﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Equal.  ISO2002 ID# _g7QEuWliEeGaMcKyqKNRfQ_-950111322.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.AccountIdentificationSearchCriteria2Choice
{
    /// <summary>
    /// Search for one or more accounts based on exact identification of the account(s).
    /// </summary>
    [IsoId("_g7QEuWliEeGaMcKyqKNRfQ_-950111322")]
    [DisplayName("Equal")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Equal : AccountIdentificationSearchCriteria2Choice_
    #else
    public partial class Equal : AccountIdentificationSearchCriteria2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        
        #nullable disable
        
    }
}
