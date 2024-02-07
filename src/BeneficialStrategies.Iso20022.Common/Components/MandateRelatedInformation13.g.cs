﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MandateRelatedInformation13.  ISO2002 ID# _rKvJEdppEeearpaEPXv9UA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details related to a direct debit mandate signed between the creditor and the debtor.
/// </summary>
public partial record MandateRelatedInformation13
     : IIsoXmlSerilizable<MandateRelatedInformation13>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the mandate.
    /// </summary>
    public required IsoMax35Text MandateIdentification { get; init; } 
    /// <summary>
    /// Date on which the direct debit mandate has been signed by the debtor.
    /// </summary>
    public IsoISODate? DateOfSignature { get; init; } 
    /// <summary>
    /// Image of scanned signed mandate.
    /// </summary>
    public IsoMax2MBBinary? MandateImage { get; init; } 
    
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
        writer.WriteStartElement(null, "MndtId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(MandateIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (DateOfSignature is IsoISODate DateOfSignatureValue)
        {
            writer.WriteStartElement(null, "DtOfSgntr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(DateOfSignatureValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (MandateImage is IsoMax2MBBinary MandateImageValue)
        {
            writer.WriteStartElement(null, "MndtImg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax2MBBinary(MandateImageValue)); // data type Max2MBBinary System.Byte[]
            writer.WriteEndElement();
        }
    }
    public static MandateRelatedInformation13 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
