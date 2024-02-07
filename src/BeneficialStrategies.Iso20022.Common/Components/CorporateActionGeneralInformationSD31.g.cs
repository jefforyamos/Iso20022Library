﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionGeneralInformationSD31.  ISO2002 ID# _Qgcssb5aEeexmbB7KsjCwA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action general information.
/// </summary>
public partial record CorporateActionGeneralInformationSD31
     : IIsoXmlSerilizable<CorporateActionGeneralInformationSD31>
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    public IsoMax350Text? PlaceAndName { get; init; } 
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    public required SecurityIdentification20 SecurityIdentification { get; init; } 
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    public required IsoRestrictedFINXMax35Text SafekeepingAccount { get; init; } 
    /// <summary>
    /// Additional information about the corporate action event.
    /// </summary>
    public CorporateActionUnallocatedDetailsSD6? UnallocatedDetails { get; init; } 
    
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
        if (PlaceAndName is IsoMax350Text PlaceAndNameValue)
        {
            writer.WriteStartElement(null, "PlcAndNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(PlaceAndNameValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SctyId", xmlNamespace );
        SecurityIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SfkpgAcct", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax35Text(SafekeepingAccount)); // data type RestrictedFINXMax35Text System.String
        writer.WriteEndElement();
        if (UnallocatedDetails is CorporateActionUnallocatedDetailsSD6 UnallocatedDetailsValue)
        {
            writer.WriteStartElement(null, "UallctdDtls", xmlNamespace );
            UnallocatedDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionGeneralInformationSD31 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
