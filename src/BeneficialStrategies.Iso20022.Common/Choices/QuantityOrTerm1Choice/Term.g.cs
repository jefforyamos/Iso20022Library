﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Term.  ISO2002 ID# _glq30SJDEe2zWP9pqvmqdw.
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
namespace BeneficialStrategies.Iso20022.Choices.QuantityOrTerm1Choice
{
    /// <summary>
    /// Frequency expressed in tenor notation.
    /// </summary>
    [IsoId("_glq30SJDEe2zWP9pqvmqdw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Term")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Term : QuantityOrTerm1Choice_
    #else
    public partial class Term : QuantityOrTerm1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Number of units of the financial instrument, that is, the nominal value.
        /// </summary>
        [IsoId("_n1kXkSJEEe2zWP9pqvmqdw")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Quantity")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoLongFraction19DecimalNumber? Quantity { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64? Quantity { get; init; } 
        #else
        public System.UInt64? Quantity { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates the unit of measure in which the total notional quantity and notional quantity schedules are expressed.
        /// </summary>
        [IsoId("_6LpXASJEEe2zWP9pqvmqdw")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Unit Of Measure")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public UnitOfMeasure8Choice_? UnitOfMeasure { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public UnitOfMeasure8Choice_? UnitOfMeasure { get; init; } 
        #else
        public UnitOfMeasure8Choice_? UnitOfMeasure { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the number of time units (as expressed by the frequency period) that determines the frequency at which periodic dates occur.
        /// </summary>
        [IsoId("_X_OJ8SJEEe2zWP9pqvmqdw")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Value")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax3Number? Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64? Value { get; init; } 
        #else
        public System.UInt64? Value { get; set; } 
        #endif
        
        /// <summary>
        /// Unit for the frequency period.
        /// </summary>
        [IsoId("_X_EY8yJEEe2zWP9pqvmqdw")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Time Unit")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Frequency19Code? TimeUnit { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Frequency19Code? TimeUnit { get; init; } 
        #else
        public Frequency19Code? TimeUnit { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
