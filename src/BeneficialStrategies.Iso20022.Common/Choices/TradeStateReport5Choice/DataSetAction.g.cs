﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DataSetAction.  ISO2002 ID# _x-2JIcK-EeuCIrYISEfoUg.
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
namespace BeneficialStrategies.Iso20022.Choices.TradeStateReport5Choice
{
    /// <summary>
    /// Where no transaction was concluded, this field should be set so that a valid trade data file can be submitted to ESMA as per daily submission requirements.
    /// </summary>
    [IsoId("_x-2JIcK-EeuCIrYISEfoUg")]
    [DisplayName("Data Set Action")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record DataSetAction : TradeStateReport5Choice_
    #else
    public partial class DataSetAction : TradeStateReport5Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a DataSetAction instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public DataSetAction( ReportPeriodActivity1Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of report activity for a specific reporting period.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DataSetActn")]
        #endif
        [IsoXmlTag("DataSetActn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ReportPeriodActivity1Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ReportPeriodActivity1Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ReportPeriodActivity1Code Value { get; init; } 
        #else
        public ReportPeriodActivity1Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
