﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentTypeInformation29.  ISO2002 ID# _gXVWIe10Eei2O5Op8j5zpA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details of the type of payment.
/// </summary>
public partial record PaymentTypeInformation29
     : IIsoXmlSerilizable<PaymentTypeInformation29>
{
    #nullable enable
    
    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the instruction.
    /// </summary>
    public Priority2Code? InstructionPriority { get; init; } 
    /// <summary>
    /// Agreement under which or rules under which the transaction should be processed.
    /// </summary>
    public ServiceLevel8Choice_? ServiceLevel { get; init; } 
    /// <summary>
    /// User community specific instrument.||Usage: This element is used to specify a local instrument, local clearing option and/or further qualify the service or service level.
    /// </summary>
    public LocalInstrument2Choice_? LocalInstrument { get; init; } 
    /// <summary>
    /// Identifies the direct debit sequence, such as first, recurrent, final or one-off.
    /// </summary>
    public SequenceType3Code? SequenceType { get; init; } 
    /// <summary>
    /// Specifies the high level purpose of the instruction based on a set of pre-defined categories.|Usage: This is used by the initiating party to provide information concerning the processing of the payment. It is likely to trigger special processing by any of the agents involved in the payment chain.
    /// </summary>
    public CategoryPurpose1Choice_? CategoryPurpose { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (InstructionPriority is Priority2Code InstructionPriorityValue)
        {
            writer.WriteStartElement(null, "InstrPrty", xmlNamespace );
            writer.WriteValue(InstructionPriorityValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ServiceLevel is ServiceLevel8Choice_ ServiceLevelValue)
        {
            writer.WriteStartElement(null, "SvcLvl", xmlNamespace );
            ServiceLevelValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LocalInstrument is LocalInstrument2Choice_ LocalInstrumentValue)
        {
            writer.WriteStartElement(null, "LclInstrm", xmlNamespace );
            LocalInstrumentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SequenceType is SequenceType3Code SequenceTypeValue)
        {
            writer.WriteStartElement(null, "SeqTp", xmlNamespace );
            writer.WriteValue(SequenceTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (CategoryPurpose is CategoryPurpose1Choice_ CategoryPurposeValue)
        {
            writer.WriteStartElement(null, "CtgyPurp", xmlNamespace );
            CategoryPurposeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PaymentTypeInformation29 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
