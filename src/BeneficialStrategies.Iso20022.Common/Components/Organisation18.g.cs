﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Organisation18.  ISO2002 ID# _HX5psXrpEeSz_of_1TY14A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card acceptor performing the transaction.
/// </summary>
public partial record Organisation18
     : IIsoXmlSerilizable<Organisation18>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the card acceptor.
    /// </summary>
    public required GenericIdentification32 Identification { get; init; } 
    /// <summary>
    /// Name of the card acceptor as appearing on the receipt or the statement of account of the cardholder.
    /// It correspond to the ISO 8583 field number 43.
    /// </summary>
    public required IsoMax70Text CommonName { get; init; } 
    /// <summary>
    /// Location of the card acceptor. 
    /// It correspond to the ISO 8583 field number 43.
    /// </summary>
    public required CommunicationAddress5 Location { get; init; } 
    /// <summary>
    /// Selected language of the card acceptor. Reference ISO 639-1 (alpha-2) andISO 639-2 (alpha-3).
    /// </summary>
    public LanguageCode? SelectedLanguage { get; init; } 
    /// <summary>
    /// Additional card acceptor data required by a card scheme.
    /// </summary>
    public IsoMax140Text? SchemeData { get; init; } 
    
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        Identification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CmonNm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax70Text(CommonName)); // data type Max70Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Lctn", xmlNamespace );
        Location.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SelectedLanguage is LanguageCode SelectedLanguageValue)
        {
            writer.WriteStartElement(null, "SelctdLang", xmlNamespace );
            writer.WriteValue(SelectedLanguageValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (SchemeData is IsoMax140Text SchemeDataValue)
        {
            writer.WriteStartElement(null, "SchmeData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(SchemeDataValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
    }
    public static Organisation18 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
