export const hey = message => {
  let phrase = message.trim();
  if (phrase.length == 0) return "Fine. Be that way!";

  if (isYell(phrase) && isQuestion(phrase) && hasLetters(phrase))
    return "Calm down, I know what I'm doing!";

  if (isYell(phrase) && hasLetters(phrase)) return "Whoa, chill out!";

  if (isQuestion(phrase)) return "Sure.";

  return "Whatever.";
};

const isYell = input => [...input].every(x => x === x.toUpperCase());
const hasLetters = input => input.match(/[a-zA-Z]/);
const isQuestion = input => input.endsWith("?");