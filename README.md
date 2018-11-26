# excelToresx

Generates resource file from an excel sheet that contains keys and values.

The excel sheet must have keys in the first column and from column 2 onwards, should have the respective translations.
Each column from 2 onwards represents a different language like following


Keys   English    Spanish  ...

key1   english1   spanish1 ...


The first row should be in the order of "Keys language-name-1 language-name-2 ..."

Second row and onwards should have "key1  language-1-value  language-2-value ..."
