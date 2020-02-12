export const value = (array) => array.length < 2 ? 0 : colorCode(array[0]) * 10 + colorCode(array[1]);

export const colorCode = (color) => COLORS.indexOf(color)

export const COLORS = ["black","brown","red","orange","yellow","green","blue","violet","grey","white"];
