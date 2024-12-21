import { IconProps } from '../types';
import { twMerge } from 'tailwind-merge';

function EditIcon({ width = 50, height = 50, className }: Partial<IconProps>) {
  return (
    <svg xmlns="http://www.w3.org/2000/svg"
    width={width}
    height={height}
    className={twMerge('text-base-accent stroke-current', className)}
    fill="none"
    viewBox="0 0 41 42" >
      <mask id="a" fill="#fff"><path d="M17.91 27.342a1 1 0 0 1-1.414 0l-2.121-2.122a1 1 0 0 1 0-1.414l13.788-13.788a2.5 2.5 0 1 1 3.536 3.535L17.91 27.342Z"></path></mask><path stroke="stroke-current" stroke-width="4" d="M17.91 27.342a1 1 0 0 1-1.414 0l-2.121-2.122a1 1 0 0 1 0-1.414l13.788-13.788a2.5 2.5 0 1 1 3.536 3.535L17.91 27.342Z" mask="url(#a)"></path><path stroke="#E0E0E0" stroke-linecap="round" stroke-opacity=".5" stroke-width="2" d="m13.257 26.93 1.528 1.529-2.904 1.376 1.376-2.905Z"></path>
    </svg>
  );
}

export { EditIcon };
