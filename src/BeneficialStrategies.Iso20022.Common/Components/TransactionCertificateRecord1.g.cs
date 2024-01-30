﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionCertificateRecord1.  ISO2002 ID# _LUhDsNLiEeSdq5yU2aaSNw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Certificate record in which all currency control transactions are registered.
/// </summary>
public partial record TransactionCertificateRecord1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the certificate record.
    /// </summary>
    public required IsoMax35Text CertificateRecordIdentification { get; init; } 
    /// <summary>
    /// Details of the transaction for which the record has been generated.
    /// </summary>
    public required TransactionCertificate2 Transaction { get; init; } 
    /// <summary>
    /// Contract registration details related to the certificate record.
    /// </summary>
    public TransactionCertificateContract1? Contract { get; init; } 
    /// <summary>
    /// Documents provided as attachments to the registered contract.
    /// </summary>
    public DocumentGeneralInformation3? Attachment { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
