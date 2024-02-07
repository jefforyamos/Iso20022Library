﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ChequeDetails.  ISO2002 ID# _SBhw5dp-Ed-ak6NoX_4Aeg_113603084.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument11Choice;

/// <summary>
/// Written order on which instructions are given to an account holder (a financial institution) to pay a stated sum to a named recipient (the payee).
/// </summary>
public partial record ChequeDetails : PaymentInstrument11Choice_
     , IIsoXmlSerilizable<ChequeDetails>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a cheque as assigned by the financial institution.
    /// </summary>
    public IsoMax35Text? Number { get; init; } 
    /// <summary>
    /// Party to which a cheque is made payable.
    /// </summary>
    public required PartyIdentification2Choice_ PayeeIdentification { get; init; } 
    /// <summary>
    /// Financial institution on which a cheque is drawn, ie, the financial institution that services the account of the entity that issued the cheque.
    /// </summary>
    public FinancialInstitutionIdentification3Choice_? DraweeIdentification { get; init; } 
    /// <summary>
    /// Account owner that issues a cheque ordering the drawee bank to pay a specific amount, upon demand, to the payee.
    /// </summary>
    public PartyIdentification2Choice_? DrawerIdentification { get; init; } 
    
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
        if (Number is IsoMax35Text NumberValue)
        {
            writer.WriteStartElement(null, "Nb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(NumberValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PyeeId", xmlNamespace );
        PayeeIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (DraweeIdentification is FinancialInstitutionIdentification3Choice_ DraweeIdentificationValue)
        {
            writer.WriteStartElement(null, "DrweeId", xmlNamespace );
            DraweeIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DrawerIdentification is PartyIdentification2Choice_ DrawerIdentificationValue)
        {
            writer.WriteStartElement(null, "DrwrId", xmlNamespace );
            DrawerIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new ChequeDetails Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
