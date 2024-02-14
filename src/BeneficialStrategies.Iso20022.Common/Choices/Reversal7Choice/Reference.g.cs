﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reference.  ISO2002 ID# _3VwHYSPvEeWQjryFgN2ITg.
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
namespace BeneficialStrategies.Iso20022.Choices.Reversal7Choice
{
    /// <summary>
    /// Reference of the transfer confirmation to be reversed.
    /// </summary>
    [IsoId("_3VwHYSPvEeWQjryFgN2ITg")]
    [DisplayName("Reference")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Reference : Reversal7Choice_
    #else
    public partial class Reference : Reversal7Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
        /// </summary>
        [IsoId("_tM0MkyVwEeWES5MJF-y6YA")]
        [DisplayName("Master Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MstrRef")]
        #endif
        [IsoXmlTag("MstrRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? MasterReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? MasterReference { get; init; } 
        #else
        public System.String? MasterReference { get; set; } 
        #endif
        
        /// <summary>
        /// Unique and unambiguous identifier for a transfer instruction, as assigned by the instructing party.
        /// </summary>
        [IsoId("_tM0MlSVwEeWES5MJF-y6YA")]
        [DisplayName("Transfer Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TrfRef")]
        #endif
        [IsoXmlTag("TrfRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? TransferReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? TransferReference { get; init; } 
        #else
        public System.String? TransferReference { get; set; } 
        #endif
        
        /// <summary>
        /// Unique and unambiguous investor&apos;s identification of a transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
        /// </summary>
        [IsoId("_tM0MlyVwEeWES5MJF-y6YA")]
        [DisplayName("Client Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ClntRef")]
        #endif
        [IsoXmlTag("ClntRef")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AdditionalReference7? ClientReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AdditionalReference7? ClientReference { get; init; } 
        #else
        public AdditionalReference7? ClientReference { get; set; } 
        #endif
        
        /// <summary>
        /// Unique and unambiguous identifier for a transfer execution, as assigned by a confirming party.
        /// </summary>
        [IsoId("_tM0MmSVwEeWES5MJF-y6YA")]
        [DisplayName("Transfer Confirmation Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TrfConfRef")]
        #endif
        [IsoXmlTag("TrfConfRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? TransferConfirmationReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? TransferConfirmationReference { get; init; } 
        #else
        public System.String? TransferConfirmationReference { get; set; } 
        #endif
        
        /// <summary>
        /// Unambiguous identification of the transfer allocated by the counterparty.
        /// </summary>
        [IsoId("_tM0MmyVwEeWES5MJF-y6YA")]
        [DisplayName("Counterparty Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CtrPtyRef")]
        #endif
        [IsoXmlTag("CtrPtyRef")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AdditionalReference7? CounterpartyReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AdditionalReference7? CounterpartyReference { get; init; } 
        #else
        public AdditionalReference7? CounterpartyReference { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
