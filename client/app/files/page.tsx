import { getUserSongs } from '@/app/action';
import { authOptions } from '@/app/api/auth/[...nextauth]/route';
import FilesTable from '@/app/files/components/table';
import PlaylistHeader from '@/components/Data/TableHeader/TableHeader';
import { PlaylistType } from '@/types';
import { getServerSession } from 'next-auth';
import { redirect } from 'next/navigation';

export default async function Files() {
  const session = await getServerSession(authOptions);
  if (!session || !session.user) return redirect('/');
  const songs = await getUserSongs(session.user.accessToken);

  if (!songs || !songs.success) return redirect('/');

  return (
    <div className="px-6 py-3 pr-5 pt-2">
      <PlaylistHeader
        title={'Your Files'}
        releaseDate={new Date()}
        tracks={songs.data}
        owner={session.user.username}
        type={PlaylistType.Files}
      />
      <FilesTable data={songs.data} type={PlaylistType.Files} />
    </div>
  );
}
