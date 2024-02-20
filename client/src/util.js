/*
let text = `<svg xmlns="http://www.w3.org/2000/svg" width="1080" height="1080" viewBox="0 0 1080 1080" xml:space="preserve"> 
            <fucking width="18401" height="412841" />`;
*/

/*
let text = `<svg height="800px" width="800px" version="1.1" id="Capa_1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" viewBox="0 0 17.485 17.485" xml:space="preserve">
<g>
	<g>
		<path style="fill:#030104;" d="M17.477,8.149c-0.079-0.739-3.976-0.581-3.976-0.581L11.853,5.23H4.275L3.168,7.567H0v2.404
			l2.029,0.682c0.123-0.836,0.843-1.48,1.711-1.48c0.939,0,1.704,0.751,1.73,1.685l6.62,0.041c0.004-0.951,0.779-1.726,1.733-1.726
			c0.854,0,1.563,0.623,1.704,1.439l1.479-0.17C17.006,10.442,17.556,8.887,17.477,8.149z M4.007,7.568l0.746-1.771h2.864
			l0.471,1.771H4.007z M8.484,7.568L8.01,5.797h3.67l1.137,1.771H8.484z"></path>
		<circle style="fill:#030104;" cx="3.759" cy="10.966" r="1.289"></circle>
		<circle style="fill:#030104;" cx="13.827" cy="10.9" r="1.29"></circle>
	</g>
</g>
</svg>`
*/

let text = `<?xml version="1.0" encoding="iso-8859-1"?>

<!-- Uploaded to: SVG Repo, www.svgrepo.com, Generator: SVG Repo Mixer Tools -->

<svg height="800px" width="800px" version="1.1" id="Capa_1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" 

	 viewBox="0 0 17.485 17.485" xml:space="preserve">

<g>

	<g>

		<path style="fill:#030104;" d="M17.477,8.149c-0.079-0.739-3.976-0.581-3.976-0.581L11.853,5.23H4.275L3.168,7.567H0v2.404

			l2.029,0.682c0.123-0.836,0.843-1.48,1.711-1.48c0.939,0,1.704,0.751,1.73,1.685l6.62,0.041c0.004-0.951,0.779-1.726,1.733-1.726

			c0.854,0,1.563,0.623,1.704,1.439l1.479-0.17C17.006,10.442,17.556,8.887,17.477,8.149z M4.007,7.568l0.746-1.771h2.864

			l0.471,1.771H4.007z M8.484,7.568L8.01,5.797h3.67l1.137,1.771H8.484z"/>

		<circle style="fill:#030104;" cx="3.759" cy="10.966" r="1.289"/>

		<circle style="fill:#030104;" cx="13.827" cy="10.9" r="1.29"/>

	</g>

</g>

</svg>`

//(?<=...) is lookbehind, (?=...) is lookahead


export function ReplaceWidth(text, width){
  const pattern = /(?<=<svg.*width=")\d*p?x?(?=".*>)/gm;
  return text.replace(pattern, `${width}`);
}

export function ReplaceWidth2(text, width){
  // uses matching groups instead of lookbehind / lookahead
  const pattern = /(<svg.*height=")(\d*[A-Za-z]*)("[\s\S]*>)/gm;
  return text.replace(pattern, `$1${width}$3`);
}

export function ReplaceHeight(text, height){
  const pattern = /(?<=<svg.*height=")\d*p?x?(?=".*>)/gm;
  return text.replace(pattern, `${height}`);
}

export function ReplaceHeight2(text, height){
  // using matching groups instead of lookbehind / lookahead
  const pattern = /(<svg.*width=")(\d*[A-Za-z]*)("[\s\S]*>)/gm;
  return text.replace(pattern, `$1${height}$3`);
}

export function Normalise(svgFile){
  let file = ReplaceWidth(svgFile, "100%");
  file = ReplaceHeight(file, "100%");
  return file;
}

export function Normalise2(svgFile){
  let file = ReplaceWidth2(svgFile, "100%");
  file = ReplaceHeight2(file, "100%");
  return file;
}

// pain peko

/*
ScaleWidthToContainer();
ScaleHeightToContainer();
*/
