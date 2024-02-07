﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrument32.  ISO2002 ID# _4iWTgRgGEeKqWJINzXcn5g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, eg, dividend option or valuation currency.
/// </summary>
public partial record FinancialInstrument32
     : IIsoXmlSerilizable<FinancialInstrument32>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of a security, assigned under a formal or proprietary identification scheme.
    /// </summary>
    public required SecurityIdentification3Choice_ Identification { get; init; } 
    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    public IsoMax350Text? Name { get; init; } 
    /// <summary>
    /// Specifies whether the financial instrument is transferred as an asset or as cash.
    /// </summary>
    public required TransferType1Code TransferType { get; init; } 
    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    public Account6? TransfereeAccount { get; init; } 
    /// <summary>
    /// Party that receives securities from the delivering agent via the place of settlement, for example, securities central depository.
    /// </summary>
    public PartyIdentificationAndAccount93? ReceivingAgentDetails { get; init; } 
    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, for example, a central securities depository.
    /// </summary>
    public PartyIdentificationAndAccount93? DeliveringAgentDetails { get; init; } 
    
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
        if (Name is IsoMax350Text NameValue)
        {
            writer.WriteStartElement(null, "Nm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(NameValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TrfTp", xmlNamespace );
        writer.WriteValue(TransferType.ToString()); // Enum value
        writer.WriteEndElement();
        if (TransfereeAccount is Account6 TransfereeAccountValue)
        {
            writer.WriteStartElement(null, "TrfeeAcct", xmlNamespace );
            TransfereeAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReceivingAgentDetails is PartyIdentificationAndAccount93 ReceivingAgentDetailsValue)
        {
            writer.WriteStartElement(null, "RcvgAgtDtls", xmlNamespace );
            ReceivingAgentDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DeliveringAgentDetails is PartyIdentificationAndAccount93 DeliveringAgentDetailsValue)
        {
            writer.WriteStartElement(null, "DlvrgAgtDtls", xmlNamespace );
            DeliveringAgentDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static FinancialInstrument32 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
