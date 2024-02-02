﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MandateRelatedInformation9.  ISO2002 ID# _tfkL4VkyEeGeoaLUQk__nA_2034090441.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details related to a direct debit mandate signed between the creditor and the debtor.
/// </summary>
[DataContract]
[XmlType]
public partial record MandateRelatedInformation9
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the mandate.
    /// </summary>
    [DataMember]
    public IsoMax35Text? MandateIdentification { get; init; } 
    /// <summary>
    /// Date on which the direct debit mandate has been signed by the debtor.
    /// </summary>
    [DataMember]
    public IsoISODate? DateOfSignature { get; init; } 
    /// <summary>
    /// Indicator notifying whether the underlying mandate is amended or not.
    /// </summary>
    [DataMember]
    public IsoTrueFalseIndicator? AmendmentIndicator { get; init; } 
    /// <summary>
    /// List of mandate elements that have been modified.
    /// </summary>
    [DataMember]
    public AmendmentInformationDetails9? AmendmentInformationDetails { get; init; } 
    /// <summary>
    /// Additional security provisions, such as a digital signature, as provided by the debtor.
    /// </summary>
    [DataMember]
    public IsoMax1025Text? ElectronicSignature { get; init; } 
    /// <summary>
    /// Date of the first collection of a direct debit as per the mandate.
    /// </summary>
    [DataMember]
    public IsoISODate? FirstCollectionDate { get; init; } 
    /// <summary>
    /// Date of the final collection of a direct debit as per the mandate.
    /// </summary>
    [DataMember]
    public IsoISODate? FinalCollectionDate { get; init; } 
    /// <summary>
    /// Regularity with which direct debit instructions are to be created and processed.
    /// </summary>
    [DataMember]
    public Frequency6Code? Frequency { get; init; } 
    
    #nullable disable
}
