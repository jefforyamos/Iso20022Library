﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CorporateActionEventProcessingStatus1Choice.  ISO2002 ID# _Qsl-Q9p-Ed-ak6NoX_4Aeg_-1300232814.
//

using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of corporate action processing status.
    /// </summary>
    [KnownType(typeof(CorporateActionEventProcessingStatus1Choice.Code))]
    [KnownType(typeof(CorporateActionEventProcessingStatus1Choice.Proprietary))]
    [IsoId("_Qsl-Q9p-Ed-ak6NoX_4Aeg_-1300232814")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Corporate Action Event Processing Status 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionEventProcessingStatus1Choice_
    #else
    public abstract partial class CorporateActionEventProcessingStatus1Choice_
    #endif
    {
    }
}
