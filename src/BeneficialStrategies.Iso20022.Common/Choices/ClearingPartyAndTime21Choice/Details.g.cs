﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Details.  ISO2002 ID# _zeYEkBZNEe2QNcZTDeoKnQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ClearingPartyAndTime21Choice;

/// <summary>
/// Indicates that the contract is cleared and provides detailes of such clearing.
/// </summary>
public partial record Details : ClearingPartyAndTime21Choice_
     , IIsoXmlSerilizable<Details>
{
    #nullable enable
    
    /// <summary>
    /// Identifies the central counterparty (CCP) that cleared the transaction.
    /// </summary>
    public OrganisationIdentification15Choice_? CCP { get; init; } 
    /// <summary>
    /// Time and date when the original derivative was received by the central counterparty for clearing.
    /// </summary>
    public IsoISODateTime? ClearingReceiptDateTime { get; init; } 
    /// <summary>
    /// Time and date when clearing took place.
    /// </summary>
    public IsoISODateTime? ClearingDateTime { get; init; } 
    /// <summary>
    /// Unique identifier of each clearing derivative that replaces the original derivative that was submitted for clearing to the central counterparty, other than the identifier for the transaction being reported.
    /// </summary>
    public UniqueTransactionIdentifier2Choice_? ClearingIdentifier { get; init; } 
    /// <summary>
    /// Unique identifier of the original derivative submitted for clearing to the central counterparty that is replaced by the clearing derivative.
    /// </summary>
    public UniqueTransactionIdentifier2Choice_? OriginalIdentifier { get; init; } 
    /// <summary>
    /// Identifies the trade repository to which the original derivative was reported.
    /// </summary>
    public OrganisationIdentification15Choice_? OriginalTradeRepositoryIdentifier { get; init; } 
    /// <summary>
    /// Indicator of whether the clearing member acted as principal for a house trade or an agent for a customer trade.
    /// </summary>
    public ClearingAccountType4Code? ClearingAccountOrigin { get; init; } 
    
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
        if (CCP is OrganisationIdentification15Choice_ CCPValue)
        {
            writer.WriteStartElement(null, "CCP", xmlNamespace );
            CCPValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ClearingReceiptDateTime is IsoISODateTime ClearingReceiptDateTimeValue)
        {
            writer.WriteStartElement(null, "ClrRctDtTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(ClearingReceiptDateTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (ClearingDateTime is IsoISODateTime ClearingDateTimeValue)
        {
            writer.WriteStartElement(null, "ClrDtTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(ClearingDateTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (ClearingIdentifier is UniqueTransactionIdentifier2Choice_ ClearingIdentifierValue)
        {
            writer.WriteStartElement(null, "ClrIdr", xmlNamespace );
            ClearingIdentifierValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OriginalIdentifier is UniqueTransactionIdentifier2Choice_ OriginalIdentifierValue)
        {
            writer.WriteStartElement(null, "OrgnlIdr", xmlNamespace );
            OriginalIdentifierValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OriginalTradeRepositoryIdentifier is OrganisationIdentification15Choice_ OriginalTradeRepositoryIdentifierValue)
        {
            writer.WriteStartElement(null, "OrgnlTradRpstryIdr", xmlNamespace );
            OriginalTradeRepositoryIdentifierValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ClearingAccountOrigin is ClearingAccountType4Code ClearingAccountOriginValue)
        {
            writer.WriteStartElement(null, "ClrAcctOrgn", xmlNamespace );
            writer.WriteValue(ClearingAccountOriginValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static new Details Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
