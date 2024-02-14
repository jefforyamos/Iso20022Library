﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OtherC10.  ISO2002 ID# _lThdb3vyEeanCNPcMT7sSg.
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
namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity3Choice
{
    /// <summary>
    /// Other C10 commodities.
    /// </summary>
    [IsoId("_lThdb3vyEeanCNPcMT7sSg")]
    [DisplayName("Other C")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record OtherC10 : AssetClassCommodity3Choice_
    #else
    public partial class OtherC10 : AssetClassCommodity3Choice_
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
