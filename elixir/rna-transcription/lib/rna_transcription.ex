defmodule RnaTranscription do
  @doc """
  Transcribes a character list representing DNA nucleotides to RNA

  ## Examples

  iex> RnaTranscription.to_rna('ACTG')
  'UGAC'
  """
  @spec to_rna([char]) :: [char]
  def to_rna(dna) do
    Enum.map(dna, &fun/1)
  end 

  defp fun(?A), do: ?U
  defp fun(?C), do: ?G
  defp fun(?T), do: ?A
  defp fun(?G), do: ?C
end
