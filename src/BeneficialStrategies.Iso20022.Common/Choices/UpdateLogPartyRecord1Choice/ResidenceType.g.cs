﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ResidenceType.  ISO2002 ID# _xPtUfmjNEeiRg5NzP0jkQg.
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
namespace BeneficialStrategies.Iso20022.Choices.UpdateLogPartyRecord1Choice
{
    /// <summary>
    /// Specifies the type of residence where the party has its permanent home or principal establishment.
    /// </summary>
    [IsoId("_xPtUfmjNEeiRg5NzP0jkQg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Residence Type")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ResidenceType : UpdateLogPartyRecord1Choice_
    #else
    public partial class ResidenceType : UpdateLogPartyRecord1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ResidenceType instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ResidenceType( ResidenceType1Code reqOld,ResidenceType1Code reqNew )
        {
            Old = reqOld;
            New = reqNew;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Old value before the update.
        /// </summary>
        [IsoId("_hgYlxWjWEeiRg5NzP0jkQg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Old")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ResidenceType1Code Old { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public ResidenceType1Code Old { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ResidenceType1Code Old { get; init; } 
        #else
        public ResidenceType1Code Old { get; set; } 
        #endif
        
        /// <summary>
        /// New value after the update.
        /// </summary>
        [IsoId("_hgYlxGjWEeiRg5NzP0jkQg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("New")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ResidenceType1Code New { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public ResidenceType1Code New { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ResidenceType1Code New { get; init; } 
        #else
        public ResidenceType1Code New { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
