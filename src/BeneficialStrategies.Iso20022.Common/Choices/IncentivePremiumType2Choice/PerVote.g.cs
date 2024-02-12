﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PerVote.  ISO2002 ID# _vMYu8_NBEeqRfth943bvEA.
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
namespace BeneficialStrategies.Iso20022.Choices.IncentivePremiumType2Choice
{
    /// <summary>
    /// Quantity of votes per type of vote giving right to a premium.
    /// </summary>
    [IsoId("_vMYu8_NBEeqRfth943bvEA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Per Vote")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record PerVote : IncentivePremiumType2Choice_
    #else
    public partial class PerVote : IncentivePremiumType2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a PerVote instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public PerVote( VoteInstructionType1Choice_ reqVoteInstructionType,System.UInt64 reqVoteQuantity )
        {
            VoteInstructionType = reqVoteInstructionType;
            VoteQuantity = reqVoteQuantity;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Types of vote instruction allowed for resolutions to be voted on in general meeting.
        /// </summary>
        [IsoId("_joPWUPNBEeqRfth943bvEA")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Vote Instruction Type")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required VoteInstructionType1Choice_ VoteInstructionType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public VoteInstructionType1Choice_ VoteInstructionType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public VoteInstructionType1Choice_ VoteInstructionType { get; init; } 
        #else
        public VoteInstructionType1Choice_ VoteInstructionType { get; set; } 
        #endif
        
        /// <summary>
        /// Quantity of vote expressed for the specified type of vote instruction.
        /// </summary>
        [IsoId("_n-JmoPNBEeqRfth943bvEA")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Vote Quantity")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoNumber VoteQuantity { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.UInt64 VoteQuantity { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64 VoteQuantity { get; init; } 
        #else
        public System.UInt64 VoteQuantity { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
