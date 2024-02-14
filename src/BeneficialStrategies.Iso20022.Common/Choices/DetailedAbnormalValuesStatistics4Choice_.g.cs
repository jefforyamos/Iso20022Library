﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DetailedAbnormalValuesStatistics4Choice.  ISO2002 ID# _x32K4VyGEe24CqbZJK5XxA.
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
    /// Detailed information of abnormal values.
    /// </summary>
    [KnownType(typeof(DetailedAbnormalValuesStatistics4Choice.DataSetAction))]
    [KnownType(typeof(DetailedAbnormalValuesStatistics4Choice.Report))]
    [IsoId("_x32K4VyGEe24CqbZJK5XxA")]
    [DisplayName("Detailed Abnormal Values Statistics 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DetailedAbnormalValuesStatistics4Choice_
    #else
    public abstract partial class DetailedAbnormalValuesStatistics4Choice_
    #endif
    {
    }
}
