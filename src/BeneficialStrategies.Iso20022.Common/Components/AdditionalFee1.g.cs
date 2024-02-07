﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalFee1.  ISO2002 ID# _mFHMkESLEeeb1MmUPTrSMw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fees not included in the transaction.
/// </summary>
public partial record AdditionalFee1
     : IIsoXmlSerilizable<AdditionalFee1>
{
    #nullable enable
    
    /// <summary>
    /// Type or class of fee.
    /// </summary>
    public required TypeOfAmount10Code Type { get; init; } 
    /// <summary>
    /// Additional information to specify the type of amount of fee.
    /// </summary>
    public IsoMax35Text? OtherType { get; init; } 
    /// <summary>
    /// Identification of fee program.
    /// </summary>
    public IsoMax35Text? FeeProgram { get; init; } 
    /// <summary>
    /// Identification of specific fee.
    /// </summary>
    public IsoMax35Text? FeeDescriptor { get; init; } 
    /// <summary>
    /// Amount of one occurrence of the fee amount.
    /// </summary>
    public required FeeAmount2 Amount { get; init; } 
    /// <summary>
    /// Short description of the fee amount.
    /// </summary>
    public IsoMax140Text? Label { get; init; } 
    
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
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        writer.WriteValue(Type.ToString()); // Enum value
        writer.WriteEndElement();
        if (OtherType is IsoMax35Text OtherTypeValue)
        {
            writer.WriteStartElement(null, "OthrTp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OtherTypeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (FeeProgram is IsoMax35Text FeeProgramValue)
        {
            writer.WriteStartElement(null, "FeePrgm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(FeeProgramValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (FeeDescriptor is IsoMax35Text FeeDescriptorValue)
        {
            writer.WriteStartElement(null, "FeeDscrptr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(FeeDescriptorValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Amt", xmlNamespace );
        Amount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Label is IsoMax140Text LabelValue)
        {
            writer.WriteStartElement(null, "Labl", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(LabelValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
    }
    public static AdditionalFee1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
