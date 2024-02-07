﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardDirectDebit2.  ISO2002 ID# _IHGYQdgyEeipBO1pkKK6zg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Element containing all information needed for a card initiating direct debit.
/// </summary>
public partial record CardDirectDebit2
     : IIsoXmlSerilizable<CardDirectDebit2>
{
    #nullable enable
    
    /// <summary>
    /// Information related to the debtor.
    /// </summary>
    public Debtor4? DebtorIdentification { get; init; } 
    /// <summary>
    /// Information related to the creditor.
    /// </summary>
    public required Creditor4 CreditorIdentification { get; init; } 
    /// <summary>
    /// Provides further details of the mandate signed between the creditor and the debtor.
    /// </summary>
    public required MandateRelatedInformation13 MandateRelatedInformation { get; init; } 
    
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
        if (DebtorIdentification is Debtor4 DebtorIdentificationValue)
        {
            writer.WriteStartElement(null, "DbtrId", xmlNamespace );
            DebtorIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CdtrId", xmlNamespace );
        CreditorIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "MndtRltdInf", xmlNamespace );
        MandateRelatedInformation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static CardDirectDebit2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
