﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TransferOutDetails.  ISO2002 ID# _ef320xXzEeOBE-jZfcm4KQ.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
namespace BeneficialStrategies.Iso20022.Choices.Cancellation4Choice
{
    /// <summary>
    /// Details of the transfer out request to cancel.
    /// </summary>
    [IsoId("_ef320xXzEeOBE-jZfcm4KQ")]
    [DisplayName("Transfer Out Details")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record TransferOutDetails : Cancellation4Choice_
    #else
    public partial class TransferOutDetails : Cancellation4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a TransferOutDetails instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public TransferOutDetails( InvestmentAccount40 reqAccountDetails )
        {
            AccountDetails = reqAccountDetails;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Requested date at which the instructing party places the transfer instruction.
        /// </summary>
        [IsoId("_BxFXJRXzEeOBE-jZfcm4KQ")]
        [DisplayName("Requested Transfer Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ReqdTrfDt")]
        #endif
        [IsoXmlTag("ReqdTrfDt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DateFormat1Choice_? RequestedTransferDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DateFormat1Choice_? RequestedTransferDate { get; init; } 
        #else
        public DateFormat1Choice_? RequestedTransferDate { get; set; } 
        #endif
        
        /// <summary>
        /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
        /// </summary>
        [IsoId("_1EZlsS73EeO59oUFO5eLvw")]
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
        /// Details of the transfer and cancellation.
        /// </summary>
        [IsoId("_RaIFIC74EeO59oUFO5eLvw")]
        [DisplayName("Transfer And References")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TrfAndRefs")]
        #endif
        [IsoXmlTag("TrfAndRefs")]
        public ValueList<TransferOut13> TransferAndReferences { get; init; } = new ValueList<TransferOut13>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _RaIFIC74EeO59oUFO5eLvw
        
        /// <summary>
        /// Information related to the account from which the financial instrument is to be withdrawn.
        /// </summary>
        [IsoId("_BxFXKRXzEeOBE-jZfcm4KQ")]
        [DisplayName("Account Details")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AcctDtls")]
        #endif
        [IsoXmlTag("AcctDtls")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required InvestmentAccount40 AccountDetails { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required InvestmentAccount40 AccountDetails { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InvestmentAccount40 AccountDetails { get; init; } 
        #else
        public InvestmentAccount40 AccountDetails { get; set; } 
        #endif
        
        /// <summary>
        /// Information related to the receiving side of the transfer.
        /// </summary>
        [IsoId("_BxFXKxXzEeOBE-jZfcm4KQ")]
        [DisplayName("Settlement Details")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SttlmDtls")]
        #endif
        [IsoXmlTag("SttlmDtls")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ReceiveInformation13? SettlementDetails { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ReceiveInformation13? SettlementDetails { get; init; } 
        #else
        public ReceiveInformation13? SettlementDetails { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information that cannot be captured in the structured elements and/or any other specific block.
        /// </summary>
        [IsoId("_BxFXLRXzEeOBE-jZfcm4KQ")]
        [DisplayName("Extension")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Xtnsn")]
        #endif
        [IsoXmlTag("Xtnsn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Extension1? Extension { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Extension1? Extension { get; init; } 
        #else
        public Extension1? Extension { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
