﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CreditTransfer3.  ISO2002 ID# _VRiwJNp-Ed-ak6NoX_4Aeg_-1711379647.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment instrument between a debtor and a creditor, which flows through one or more financial institutions or systems.
/// </summary>
public partial record CreditTransfer3
     : IIsoXmlSerilizable<CreditTransfer3>
{
    #nullable enable
    
    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts' receivable system.
    /// </summary>
    public IsoMax35Text? Reference { get; init; } 
    /// <summary>
    /// Party that receives an amount of money from the debtor. The creditor is also the credit account owner.
    /// </summary>
    public required Creditor2 CreditorDetails { get; init; } 
    /// <summary>
    /// Party that owes an amount of money to the creditor. The debtor is also the debit account owner.
    /// </summary>
    public Debtor2? DebtorDetails { get; init; } 
    
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
        if (Reference is IsoMax35Text ReferenceValue)
        {
            writer.WriteStartElement(null, "Ref", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CdtrDtls", xmlNamespace );
        CreditorDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (DebtorDetails is Debtor2 DebtorDetailsValue)
        {
            writer.WriteStartElement(null, "DbtrDtls", xmlNamespace );
            DebtorDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CreditTransfer3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
