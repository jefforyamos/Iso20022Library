﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyProfileInformation5.  ISO2002 ID# _HEMRASGREeWO8_xZKx-MFg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information to support the Know Your Customer (KYC) processes.
/// </summary>
public partial record PartyProfileInformation5
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the certificate type has been obtained and verified.
    /// </summary>
    public IsoYesNoIndicator? CertificationIndicator { get; init; } 
    /// <summary>
    /// Identification of the person who validated the document.
    /// </summary>
    public IsoMax140Text? ValidatingParty { get; init; } 
    /// <summary>
    /// Identification of the person who checked the document.
    /// </summary>
    public IsoMax140Text? CheckingParty { get; init; } 
    /// <summary>
    /// Identification of the person who is responsible for the document.
    /// </summary>
    public IsoMax140Text? ResponsibleParty { get; init; } 
    /// <summary>
    /// Type of certificate.
    /// </summary>
    public ICertificationType1Choice? CertificateType { get; init; } 
    /// <summary>
    /// Date at which the certification check has been performed.
    /// </summary>
    public IsoISODate? CheckingDate { get; init; } 
    /// <summary>
    /// Specifies how frequently the check is performed.
    /// </summary>
    public EventFrequency1Code? CheckingFrequency { get; init; } 
    /// <summary>
    /// Specifies the date at which the next certification check will be performed.
    /// </summary>
    public IsoISODate? NextRevisionDate { get; init; } 
    /// <summary>
    /// Limits between which a person's salary is estimated.
    /// </summary>
    public IsoMax35Text? SalaryRange { get; init; } 
    /// <summary>
    /// Indicates the main source of revenue.
    /// </summary>
    public IsoMax140Text? SourceOfWealth { get; init; } 
    /// <summary>
    /// Specifies an assessment of the customer’s behaviour at the time of the account opening application.
    /// </summary>
    public ICustomerConductClassification1Choice? CustomerConductClassification { get; init; } 
    /// <summary>
    /// Specifies the customer’s money laundering risk.
    /// </summary>
    public IRiskLevel2Choice? RiskLevel { get; init; } 
    /// <summary>
    /// Specifies the type of due diligence checks carried out on the investor or account owner. For definitions of ordinary, simple and enhanced know your customer checks, local market regulations should be consulted.
    /// </summary>
    public IKYCCheckType1Choice? KnowYourCustomerCheckType { get; init; } 
    /// <summary>
    /// Specifies whether a customer has been checked in a Know Your Customer (KYC) database.
    /// </summary>
    public DataBaseCheck1? KnowYourCustomerDatabaseCheck { get; init; } 
    
    #nullable disable
}
