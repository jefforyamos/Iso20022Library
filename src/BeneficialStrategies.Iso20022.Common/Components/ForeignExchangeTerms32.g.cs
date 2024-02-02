﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ForeignExchangeTerms32.  ISO2002 ID# _zkLg1zbsEead9bDRE_1DAQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information needed to process a currency exchange or conversion.
/// </summary>
[DataContract]
[XmlType]
public partial record ForeignExchangeTerms32
{
    #nullable enable
    
    /// <summary>
    /// Currency from which the quoted currency is converted in an exchange rate calculation.
    /// 1 x <UnitCcy> = <XchgRate> x <QtdCcy>.
    /// </summary>
    [DataMember]
    public required ActiveCurrencyCode UnitCurrency { get; init; } 
    /// <summary>
    /// Currency into which the unit currency is converted in an exchange rate calculation.
    /// 1 x <UnitCcy> = <XchgRate> x <QtdCcy>.
    /// </summary>
    [DataMember]
    public required ActiveCurrencyCode QuotedCurrency { get; init; } 
    /// <summary>
    /// Factor used for the conversion of an amount from one currency into another. This reflects that amount of the quoted currency that can be purchased with one unit of the unit currency, as follows: 
    /// 1 x CUR1 = nnn x CUR2, 
    /// where: 
    /// CUR1 is the unit currency 
    /// CUR2 is the quoted currency 
    /// nnn is the exchange rate.
    /// 1 x <UnitCcy> = <XchgRate> x <QtdCcy>.
    /// </summary>
    [DataMember]
    public required IsoBaseOneRate ExchangeRate { get; init; } 
    /// <summary>
    /// Date and time at which an exchange rate is quoted.
    /// </summary>
    [DataMember]
    public IsoISODateTime? QuotationDate { get; init; } 
    /// <summary>
    /// Party that proposes a foreign exchange rate.
    /// </summary>
    [DataMember]
    public PartyIdentification113? QuotingInstitution { get; init; } 
    
    #nullable disable
}
