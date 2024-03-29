﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DocumentType4Code.  ISO2002 ID# _agObhtp-Ed-ak6NoX_4Aeg_1538718014.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the document for example commercial invoice, credit note, debit note.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_agObhtp-Ed-ak6NoX_4Aeg_1538718014")]
[Description(@"Specifies the type of the document for example commercial invoice, credit note, debit note.")]
[DerivedFrom(typeof(DocumentTypeCode))]
public enum DocumentType4Code
{
    /// <summary>
    /// Document is an invoice.
    /// Encoded/decoded by serializers as &quot;CINV&quot;.
    /// </summary>
    [EnumMember(Value = "CINV")]
    [IsoId("_agObh9p-Ed-ak6NoX_4Aeg_1538718054")]
    [Description(@"Document is an invoice.")]
    CommercialInvoice = DocumentTypeCode.CommercialInvoice, // same ordinal as derivation source for type conversions
    
}
