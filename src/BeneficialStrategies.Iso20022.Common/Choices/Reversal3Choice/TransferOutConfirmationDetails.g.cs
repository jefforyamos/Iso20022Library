﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TransferOutConfirmationDetails.  ISO2002 ID# _QcQDsxX2EeOBE-jZfcm4KQ.
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
namespace BeneficialStrategies.Iso20022.Choices.Reversal3Choice
{
    /// <summary>
    /// Details of the transfer out confirmation to be reversed.
    /// </summary>
    [IsoId("_QcQDsxX2EeOBE-jZfcm4KQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transfer Out Confirmation Details")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record TransferOutConfirmationDetails : Reversal3Choice_
    #else
    public partial class TransferOutConfirmationDetails : Reversal3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a TransferOutConfirmationDetails instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public TransferOutConfirmationDetails( InvestmentAccount40 reqAccountDetails )
        {
            AccountDetails = reqAccountDetails;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
        /// </summary>
        [IsoId("_o4UboC79EeO59oUFO5eLvw")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Master Reference")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? MasterReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? MasterReference { get; init; } 
        #else
        public System.String? MasterReference { get; set; } 
        #endif
        
        /// <summary>
        /// General information related to the transfer of a financial instrument.
        /// </summary>
        [IsoId("_GRF3RxX2EeOBE-jZfcm4KQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Transfer Details")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        public Transfer28? TransferDetails { get; init;  } // Warning: Don't know multiplicity.
        // ID for the above is _GRF3RxX2EeOBE-jZfcm4KQ
        
        /// <summary>
        /// Information related to the account from which the financial instrument was withdrawn.
        /// </summary>
        [IsoId("_GRF3SRX2EeOBE-jZfcm4KQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Account Details")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required InvestmentAccount40 AccountDetails { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public InvestmentAccount40 AccountDetails { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InvestmentAccount40 AccountDetails { get; init; } 
        #else
        public InvestmentAccount40 AccountDetails { get; set; } 
        #endif
        
        /// <summary>
        /// Information related to the receiving side of the transfer.
        /// </summary>
        [IsoId("_GRF3SxX2EeOBE-jZfcm4KQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Settlement Details")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ReceiveInformation12? SettlementDetails { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ReceiveInformation12? SettlementDetails { get; init; } 
        #else
        public ReceiveInformation12? SettlementDetails { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_GRF3TRX2EeOBE-jZfcm4KQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Extension")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
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
