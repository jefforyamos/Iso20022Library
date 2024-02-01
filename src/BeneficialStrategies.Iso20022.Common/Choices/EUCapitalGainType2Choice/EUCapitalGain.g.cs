﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for EUCapitalGain.  ISO2002 ID# _f57zwdoqEeCWg-hsBVGrDA_-1285095574.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.EUCapitalGainType2Choice;

/// <summary>
/// Specifies whether capital gain is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, a refund or redemption of shares and units, etc.
/// </summary>
public partial record EUCapitalGain : EUCapitalGainType2Choice_
{
    public required EUCapitalGain2Code Value { get; init; }
}
