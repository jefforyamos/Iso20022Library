﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BinaryData.  ISO2002 ID# _-on81OkLEemeDPHh-U9b6w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.EncryptedData1Choice;

/// <summary>
/// BASE-64 encoded encrypted data.
/// </summary>
public partial record BinaryData : EncryptedData1Choice_
{
    public required IsoMax100KBinary Value { get; init; }
}
