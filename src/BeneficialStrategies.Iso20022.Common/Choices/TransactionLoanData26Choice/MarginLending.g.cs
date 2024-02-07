﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MarginLending.  ISO2002 ID# _3-z253z2EeurrJrNxcsszQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.TransactionLoanData26Choice;

/// <summary>
/// Details of the margin lending transaction.
/// </summary>
public partial record MarginLending : TransactionLoanData26Choice_
     , IIsoXmlSerilizable<MarginLending>
{
    #nullable enable
    
    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
    /// </summary>
    public required IsoISODate EventDate { get; init; } 
    /// <summary>
    /// Unique trade Identifier (UTI) as agreed with the other counterparty.
    /// </summary>
    public IsoMax52Text? UniqueTradeIdentifier { get; init; } 
    /// <summary>
    /// Reference to master agreement under which the counterparties concluded a documented transaction.
    /// </summary>
    public MasterAgreement7? MasterAgreement { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "EvtDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(EventDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        if (UniqueTradeIdentifier is IsoMax52Text UniqueTradeIdentifierValue)
        {
            writer.WriteStartElement(null, "UnqTradIdr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax52Text(UniqueTradeIdentifierValue)); // data type Max52Text System.String
            writer.WriteEndElement();
        }
        if (MasterAgreement is MasterAgreement7 MasterAgreementValue)
        {
            writer.WriteStartElement(null, "MstrAgrmt", xmlNamespace );
            MasterAgreementValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new MarginLending Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
