defmodule RnaTranscription do
  @doc """
  Transcribes a character list representing DNA nucleotides to RNA

  ## Examples

  iex> RnaTranscription.to_rna('ACTG')
  'UGAC'
  """
  @spec to_rna([char]) :: [char]
  def to_rna(dna) do
    transcriptions = %{?A => ?U, ?C => ?G, ?T => ?A, ?G => ?C}
    Enum.map(dna, fn x -> transcriptions[x] end)
  end 
end
