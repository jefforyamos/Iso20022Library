﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionSecuritiesMovement1.  ISO2002 ID# _UIYIptp-Ed-ak6NoX_4Aeg_1464286927.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the securities movements.
/// </summary>
public partial record CorporateActionSecuritiesMovement1
     : IIsoXmlSerilizable<CorporateActionSecuritiesMovement1>
{
    #nullable enable
    
    /// <summary>
    /// Date and time of the posting.
    /// </summary>
    public DateAndDateTimeChoice_? PostingDateTime { get; init; } 
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    public required SecurityIdentification7 SecurityIdentification { get; init; } 
    /// <summary>
    /// Quantity of securities that is posted.
    /// </summary>
    public required UnitOrFaceAmount1Choice_ PostingQuantity { get; init; } 
    /// <summary>
    /// Provides information about the account which is debited/credited.
    /// </summary>
    public ValueList<SecuritiesAccount8> AccountDetails { get; init; } = [];
    
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
        if (PostingDateTime is DateAndDateTimeChoice_ PostingDateTimeValue)
        {
            writer.WriteStartElement(null, "PstngDtTm", xmlNamespace );
            PostingDateTimeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SctyId", xmlNamespace );
        SecurityIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PstngQty", xmlNamespace );
        PostingQuantity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AcctDtls", xmlNamespace );
        AccountDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static CorporateActionSecuritiesMovement1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
